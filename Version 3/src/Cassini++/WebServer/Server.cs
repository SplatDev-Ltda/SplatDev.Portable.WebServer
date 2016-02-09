/* **********************************************************************************
 *
 * Copyright (c) Microsoft Corporation. All rights reserved.
 *
 * This source code is subject to terms and conditions of the Microsoft Public
 * License (Ms-PL). A copy of the license can be found in the license.htm file
 * included in this distribution.
 *
 * You must not remove this notice, or any other, from this software.
 *
 * **********************************************************************************/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Threading;
using System.Web;
using System.Web.Hosting;
using PiW.WebServer.Utilities;

namespace PiW.WebServer
{
    public class Server : MarshalByRefObject
    {
        private int _port;
        private string _virtualPath;
        private string _physicalPath;
        private bool _shutdownInProgress;
        private Socket _socket;
        private Host _host;
        private IPAddress _listenAddress;
        private AppType _appType;
        private const string LOCALHOST = "http://localhost";
        public const string MVCHome = "/Home";

        public event EventHandler Stopped;
        public event EventHandler Started;

        public Server(int port, string virtualPath, string physicalPath, IPAddress listenAddress, AppType type)
        {
            _port = port;
            _virtualPath = virtualPath;
            _physicalPath = physicalPath.EndsWith("\\", StringComparison.Ordinal) ? physicalPath : physicalPath + "\\";
            _listenAddress = listenAddress;
            _appType = type;
        }

        public override object InitializeLifetimeService()
        {
            // never expire the license
            return null;
        }

        public string VirtualPath
        {
            get { return _virtualPath; }
        }

        public string PhysicalPath
        {
            get { return _physicalPath; }
        }

        public int Port
        {
            get { return _port; }
        }

        public AppType AppType { get { return _appType; } }

        public string RootUrl
        {
            get
            {
                if (_port != 80)
                {
                    return string.Format("{0}:{1}{2}", LOCALHOST, _port, _virtualPath);
                }
                else
                {
                    return string.Format("{0}{1}", LOCALHOST, _virtualPath);
                }
            }
        }

        public string MVCHomePath { get { return MVCHome; } }

        //
        // Socket listening
        // 

        private static Socket CreateSocketBindAndListen(AddressFamily family, IPAddress address, int port)
        {
            var socket = new Socket(family, SocketType.Stream, ProtocolType.Tcp);

            socket.Bind(new IPEndPoint(address, port));
            socket.Listen((int)SocketOptionName.MaxConnections);

            return socket;
        }

        public void Start()
        {
            try
            {
                _socket = CreateSocketBindAndListen(AddressFamily.InterNetwork, _listenAddress, _port);
            }
            catch
            {
                // Any Address is valid for IPv6 and IPv4 as well.
                // So this exception will only occur in pure IPv6 environments with 
                // _listenAddress set to IPv4 Loopback
                _socket = CreateSocketBindAndListen(AddressFamily.InterNetworkV6, IPAddress.IPv6Loopback, _port);
            }

            ThreadPool.QueueUserWorkItem(delegate
                                            {
                                                while (!_shutdownInProgress)
                                                {
                                                    try
                                                    {
                                                        Socket acceptedSocket = _socket.Accept();

                                                        ThreadPool.QueueUserWorkItem(delegate
                                                                                        {
                                                                                            if (!_shutdownInProgress)
                                                                                            {
                                                                                                var conn = new Connection(this, acceptedSocket);

                                                                                                // wait for at least some input
                                                                                                if (conn.WaitForRequestBytes() == 0)
                                                                                                {
                                                                                                    conn.WriteErrorAndClose(400);
                                                                                                    return;
                                                                                                }

                                                                                                // find or create host
                                                                                                Host host = GetHost();
                                                                                                if (host == null)
                                                                                                {
                                                                                                    conn.WriteErrorAndClose(500);
                                                                                                    return;
                                                                                                }

                                                                                                // process request in worker app domain
                                                                                                host.ProcessRequest(conn);
                                                                                            }
                                                                                        });
                                                    }
                                                    catch
                                                    {
                                                        Thread.Sleep(100);
                                                    }
                                                }
                                            });

            if (Started != null)
            {
                Started(this, new EventArgs());
            }
        }

        public void Stop()
        {
            _shutdownInProgress = true;

            try
            {
                if (_socket != null)
                {
                    _socket.Close();
                }
            }
            catch
            {
            }
            finally
            {
                _socket = null;
            }

            try
            {
                if (_host != null)
                {
                    _host.Shutdown();
                }

                while (_host != null)
                {
                    Thread.Sleep(100);
                }
            }
            catch
            {
            }

            finally
            {
                _host = null;
            }

            if (Stopped != null)
            {
                Stopped(this, new EventArgs());
            }
        }

        // called at the end of request processing
        // to disconnect the remoting proxy for Connection object
        // and allow GC to pick it up
        public void OnRequestEnd(Connection conn)
        {
            RemotingServices.Disconnect(conn);
        }

        public void HostStopped()
        {
            _host = null;
        }

        private Host GetHost()
        {
            if (_shutdownInProgress)
            {
                return null;
            }

            Host host = _host;

            if (host == null)
            {
                lock (this)
                {
                    host = _host;
                    if (host == null)
                    {
                        host = CreateWorkerAppDomainWithHost(_virtualPath, _physicalPath);
                        host.Configure(this, _port, _virtualPath, _physicalPath);
                        _host = host;
                    }
                }
            }

            return host;
        }

        private static Host CreateWorkerAppDomainWithHost(string virtualPath, string physicalPath)
        {
            var hostType = typeof(Host);

            // this creates worker app domain in a way that host doesn't need to be in GAC or bin
            // using BuildManagerHost via private reflection
            string uniqueAppString = string.Concat(virtualPath, physicalPath).ToLowerInvariant();
            string appId = (uniqueAppString.GetHashCode()).ToString("x", CultureInfo.InvariantCulture);

            // create BuildManagerHost in the worker app domain
            var appManager = ApplicationManager.GetApplicationManager();
            var buildManagerHostType = typeof(HttpRuntime).Assembly.GetType("System.Web.Compilation.BuildManagerHost");
            var buildManagerHost = appManager.CreateObject(appId, buildManagerHostType, virtualPath, physicalPath, false);

            // call BuildManagerHost.RegisterAssembly to make Host type loadable in the worker app domain
            buildManagerHostType.InvokeMember(
                "RegisterAssembly",
                BindingFlags.Instance | BindingFlags.InvokeMethod | BindingFlags.NonPublic,
                null,
                buildManagerHost,
                new object[2] { hostType.Assembly.FullName, hostType.Assembly.Location });

            // create Host in the worker app domain
            return (Host)appManager.CreateObject(appId, hostType, virtualPath, physicalPath, false);
        }
    }
}