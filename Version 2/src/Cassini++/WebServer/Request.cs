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
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Web;
using System.Web.Hosting;

using Microsoft.Win32.SafeHandles;

using Cassinipp.WebServer.Processors;
using Cassinipp.WebServer.Utilities;

namespace Cassinipp.WebServer
{
	public class Request : SimpleWorkerRequest
	{
		private static readonly char[] badPathChars = new[] {'%', '>', '<', ':', '\\'};

		private static readonly char[] IntToHex = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };

		private const int MaxChunkLength = 64*1024;

		public Server Server { get; private set; }
		public Host Host { get; private set; }
		public Connection Connection { get; private set; }

		public IRequestProcessor ProcessorChain { get; private set; }

		// security permission to Assert remoting calls to _connection
		private readonly IStackWalk _connectionPermission = new PermissionSet(PermissionState.Unrestricted);

		// raw request data
		private const int maxHeaderBytes = 32*1024;
		private byte[] _headerBytes;
		private int _startHeadersOffset;
		private int _endHeadersOffset;
		private List<ByteString> _headerByteStrings;

		// parsed request data

		public bool IsClientScriptPath { get; private set; }

		public string Verb { get; private set; }
        public string Url { get; private set; }
        public string Prot { get; private set; }

		public string Path { get; private set; }

		public string FilePath { get; private set; }
		public string PathInfo { get; private set; }
		public string PathTranslated { get; private set; }

		public String QueryString { get; private set; }
		private byte[] _queryStringBytes;

        public AppType AppType { get { return Server.AppType; } }

		public int ContentLength { get; private set; }
		public int PreloadedContentLength { get; private set; }

		private byte[] _preloadedContent;

		private string _allRawHeaders;
		private string[][] _unknownRequestHeaders;
		private string[] _knownRequestHeaders;
		private bool _specialCaseStaticFileHeaders;

		// cached response
		private bool _headersSent;
        public int ResponseStatus { get; private set; }
		private StringBuilder _responseHeadersBuilder;
		private List<byte[]> _responseBodyBytes;

		public Request(Server server, Host host, Connection connection) : base(String.Empty, String.Empty, null)
		{
			Server = server;
			Host = host;
			Connection = connection;

            ProcessorChain = RequestProcessorChainBuilder.Current.Build();
		}

		public void Process()
		{
            ProcessorChain.Pre(this);

			// read the request
			if (!TryParseRequest())
			{
				return;
			}

            ProcessorChain.Intercept(this);

            ProcessorChain.Post(this);
		}

		private void Reset()
		{
			_headerBytes = null;
			_startHeadersOffset = 0;
			_endHeadersOffset = 0;
			_headerByteStrings = null;

			IsClientScriptPath = false;

			Verb = null;
			Url = null;
			Prot = null;

			Path = null;
			FilePath = null;
			PathInfo = null;
			PathTranslated = null;
			QueryString = null;
			_queryStringBytes = null;

			ContentLength = 0;
			PreloadedContentLength = 0;
			_preloadedContent = null;

			_allRawHeaders = null;
			_unknownRequestHeaders = null;
			_knownRequestHeaders = null;
			_specialCaseStaticFileHeaders = false;
		}

		private bool TryParseRequest()
		{
			Reset();

			ReadAllHeaders();

			if (_headerBytes == null || _endHeadersOffset < 0 ||
			    _headerByteStrings == null || _headerByteStrings.Count == 0)
			{
				Connection.WriteErrorAndClose(400);
				return false;
			}

			ParseRequestLine();

			// Check for bad path
			if (IsBadPath())
			{
				Connection.WriteErrorAndClose(400);
				return false;
			}

			bool clientScriptPath;

			// Check if the path is not well formed or is not for the current app
			if (!Host.IsVirtualPathInApp(Path, out clientScriptPath))
			{
				// HACK: Avoid out parameter!!!
				IsClientScriptPath = clientScriptPath;

				Connection.WriteErrorAndClose(404);
				return false;
			}

			// HACK: Avoid out parameter!!!
			IsClientScriptPath = clientScriptPath;

			ParseHeaders();

			ParsePostedContent();

			return true;
		}

		private bool TryReadAllHeaders()
		{
			// read the first packet (up to 32K)
			byte[] headerBytes = Connection.ReadRequestBytes(maxHeaderBytes);

			if (headerBytes == null || headerBytes.Length == 0)
			{
				return false;
			}

			if (_headerBytes != null)
			{
				// previous partial read
				int len = headerBytes.Length + _headerBytes.Length;
				if (len > maxHeaderBytes)
				{
					return false;
				}

				var bytes = new byte[len];
				Buffer.BlockCopy(_headerBytes, 0, bytes, 0, _headerBytes.Length);
				Buffer.BlockCopy(headerBytes, 0, bytes, _headerBytes.Length, headerBytes.Length);
				_headerBytes = bytes;
			}
			else
			{
				_headerBytes = headerBytes;
			}

			// start parsing
			_startHeadersOffset = -1;
			_endHeadersOffset = -1;
			_headerByteStrings = new List<ByteString>();

			// find the end of headers
			var parser = new ByteParser(_headerBytes);

			for (;;)
			{
				ByteString line = parser.ReadLine();

				if (line == null)
				{
					break;
				}

				if (_startHeadersOffset < 0)
				{
					_startHeadersOffset = parser.CurrentOffset;
				}

				if (line.IsEmpty)
				{
					_endHeadersOffset = parser.CurrentOffset;
					break;
				}

				_headerByteStrings.Add(line);
			}

			return true;
		}

		private void ReadAllHeaders()
		{
			_headerBytes = null;

			do
			{
				if (!TryReadAllHeaders())
				{
					// something bad happened
					break;
				}
			} while (_endHeadersOffset < 0); // found \r\n\r\n
		}

		private void ParseRequestLine()
		{
			var requestLine = _headerByteStrings[0];
			var elems = requestLine.Split(' ');

			if (elems == null || elems.Length < 2 || elems.Length > 3)
			{
				Connection.WriteErrorAndClose(400);
				return;
			}

			Verb = elems[0].GetString();

			var urlBytes = elems[1];
			Url = urlBytes.GetString();

			if (elems.Length == 3)
			{
				Prot = elems[2].GetString();
			}
			else
			{
				Prot = "HTTP/1.0";
			}

			// query string

			int iqs = urlBytes.IndexOf('?');
			if (iqs > 0)
			{
				_queryStringBytes = urlBytes.Substring(iqs + 1).GetBytes();
			}
			else
			{
				_queryStringBytes = new byte[0];
			}

			iqs = Url.IndexOf('?');
			if (iqs > 0)
			{
				Path = Url.Substring(0, iqs);
				QueryString = Url.Substring(iqs + 1);
			}
			else
			{
				Path = Url;
				_queryStringBytes = new byte[0];
			}

			// url-decode path

			if (Path.IndexOf('%') >= 0)
			{
				Path = HttpUtility.UrlDecode(Path, Encoding.UTF8);

				iqs = Url.IndexOf('?');
				if (iqs >= 0)
				{
					Url = Path + Url.Substring(iqs);
				}
				else
				{
					Url = Path;
				}
			}

			// path info

			var lastDot = Path.LastIndexOf('.');
			var lastSlh = Path.LastIndexOf('/');

			if (lastDot >= 0 && lastSlh >= 0 && lastDot < lastSlh)
			{
				var ipi = Path.IndexOf('/', lastDot);
				FilePath = Path.Substring(0, ipi);
				PathInfo = Path.Substring(ipi);
			}
			else
			{
				FilePath = Path;
				PathInfo = String.Empty;
			}

			PathTranslated = MapPath(FilePath);
		}

		private bool IsBadPath()
		{
			if (Path.IndexOfAny(badPathChars) >= 0)
			{
				return true;
			}

			if (CultureInfo.InvariantCulture.CompareInfo.IndexOf(Path, "..", CompareOptions.Ordinal) >= 0)
			{
				return true;
			}

			if (CultureInfo.InvariantCulture.CompareInfo.IndexOf(Path, "//", CompareOptions.Ordinal) >= 0)
			{
				return true;
			}

			return false;
		}

		private void ParseHeaders()
		{
			_knownRequestHeaders = new string[RequestHeaderMaximum];

			// construct unknown headers as array list of name1,value1,...
			var headers = new List<string>();

			for (var i = 1; i < _headerByteStrings.Count; i++)
			{
				var s = _headerByteStrings[i].GetString();

				var c = s.IndexOf(':');

				if (c >= 0)
				{
					string name = s.Substring(0, c).Trim();
					string value = s.Substring(c + 1).Trim();

					// remember
					int knownIndex = GetKnownRequestHeaderIndex(name);
					if (knownIndex >= 0)
					{
						_knownRequestHeaders[knownIndex] = value;
					}
					else
					{
						headers.Add(name);
						headers.Add(value);
					}
				}
			}

			// copy to array unknown headers

			var n = headers.Count/2;
			_unknownRequestHeaders = new string[n][];
			var j = 0;

			for (var i = 0; i < n; i++)
			{
				_unknownRequestHeaders[i] = new string[2];
				_unknownRequestHeaders[i][0] = headers[j++];
				_unknownRequestHeaders[i][1] = headers[j++];
			}

			// remember all raw headers as one string

			if (_headerByteStrings.Count > 1)
			{
				_allRawHeaders = Encoding.UTF8.GetString(_headerBytes, _startHeadersOffset, _endHeadersOffset - _startHeadersOffset);
			}
			else
			{
				_allRawHeaders = String.Empty;
			}
		}

		private void ParsePostedContent()
		{
			ContentLength = 0;
			PreloadedContentLength = 0;

			var contentLengthValue = _knownRequestHeaders[HeaderContentLength];
			if (contentLengthValue != null)
			{
				try
				{
					ContentLength = Int32.Parse(contentLengthValue, CultureInfo.InvariantCulture);
				}
				catch
				{
				}
			}

			if (_headerBytes.Length > _endHeadersOffset)
			{
				PreloadedContentLength = _headerBytes.Length - _endHeadersOffset;

				if (PreloadedContentLength > ContentLength)
				{
					PreloadedContentLength = ContentLength; // don't read more than the content-length
				}

				if (PreloadedContentLength > 0)
				{
					_preloadedContent = new byte[PreloadedContentLength];
					Buffer.BlockCopy(_headerBytes, _endHeadersOffset, _preloadedContent, 0, PreloadedContentLength);
				}
			}
		}


		public string UrlEncodeRedirect(string path)
		{
			// this method mimics the logic in HttpResponse.Redirect (which relies on internal methods)

			// count non-ascii characters
			var bytes = Encoding.UTF8.GetBytes(path);
			var count = bytes.Length;
			var countNonAscii = 0;
			for (var i = 0; i < count; i++)
			{
				if ((bytes[i] & 0x80) != 0)
				{
					countNonAscii++;
				}
			}

			// encode all non-ascii characters using UTF-8 %XX
			if (countNonAscii > 0)
			{
				// expand not 'safe' characters into %XX, spaces to +s
				var expandedBytes = new byte[count + countNonAscii*2];
				var pos = 0;
				for (var i = 0; i < count; i++)
				{
					var b = bytes[i];

					if ((b & 0x80) == 0)
					{
						expandedBytes[pos++] = b;
					}
					else
					{
						expandedBytes[pos++] = (byte) '%';
						expandedBytes[pos++] = (byte) IntToHex[(b >> 4) & 0xf];
						expandedBytes[pos++] = (byte) IntToHex[b & 0xf];
					}
				}

				path = Encoding.ASCII.GetString(expandedBytes);
			}

			// encode spaces into %20
			if (path.IndexOf(' ') >= 0)
			{
				path = path.Replace(" ", "%20");
			}

			return path;
		}

		public void PrepareResponse()
		{
			_headersSent = false;
			ResponseStatus = 200;
			_responseHeadersBuilder = new StringBuilder();
			_responseBodyBytes = new List<byte[]>();
		}

		///////////////////////////////////////////////////////////////////////////////////////////////
		// Implementation of HttpWorkerRequest

		public override string GetUriPath()
		{
			return Path;
		}

		public override string GetQueryString()
		{
			return QueryString;
		}

		public override byte[] GetQueryStringRawBytes()
		{
			return _queryStringBytes;
		}

		public override string GetRawUrl()
		{
			return Url;
		}

		public override string GetHttpVerbName()
		{
			return Verb;
		}

		public override string GetHttpVersion()
		{
			return Prot;
		}

		public override string GetRemoteAddress()
		{
			_connectionPermission.Assert();
			return Connection.RemoteIP;
		}

		public override int GetRemotePort()
		{
			return 0;
		}

		public override string GetLocalAddress()
		{
			_connectionPermission.Assert();
			return Connection.LocalIP;
		}

		public override string GetServerName()
		{
			var localAddress = GetLocalAddress();
			if (localAddress.Equals("127.0.0.1"))
			{
				return "localhost";
			}
			return localAddress;
		}

		public override int GetLocalPort()
		{
			return Host.Port;
		}

		public override string GetFilePath()
		{
			return FilePath;
		}

		public override string GetFilePathTranslated()
		{
			return PathTranslated;
		}

		public override string GetPathInfo()
		{
			return PathInfo;
		}

		public override string GetAppPath()
		{
			return Host.VirtualPath;
		}

		public override string GetAppPathTranslated()
		{
			return Host.PhysicalPath;
		}

		public override byte[] GetPreloadedEntityBody()
		{
			return _preloadedContent;
		}

		public override bool IsEntireEntityBodyIsPreloaded()
		{
			return (ContentLength == PreloadedContentLength);
		}

		public override int ReadEntityBody(byte[] buffer, int size)
		{
			var bytesRead = 0;

			_connectionPermission.Assert();
			var bytes = Connection.ReadRequestBytes(size);

			if (bytes != null && bytes.Length > 0)
			{
				bytesRead = bytes.Length;
				Buffer.BlockCopy(bytes, 0, buffer, 0, bytesRead);
			}

			return bytesRead;
		}

		public override string GetKnownRequestHeader(int index)
		{
			return _knownRequestHeaders[index];
		}

		public override string GetUnknownRequestHeader(string name)
		{
			var n = _unknownRequestHeaders.Length;

			for (var i = 0; i < n; i++)
			{
				if (string.Compare(name, _unknownRequestHeaders[i][0], StringComparison.OrdinalIgnoreCase) == 0)
				{
					return _unknownRequestHeaders[i][1];
				}
			}

			return null;
		}

		public override string[][] GetUnknownRequestHeaders()
		{
			return _unknownRequestHeaders;
		}

		public override string GetServerVariable(string name)
		{
			var s = String.Empty;

			switch (name)
			{
				case "ALL_RAW":
					s = _allRawHeaders;
					break;

				case "SERVER_PROTOCOL":
					s = Prot;
					break;

				case "SERVER_SOFTWARE":
					s = "Cassini/" + Messages.VersionString;
					break;
			}

			return s;
		}

		public override string MapPath(string path)
		{
			string mappedPath;
			bool isClientScriptPath;

			if (String.IsNullOrEmpty(path) || path.Equals("/"))
			{
				// asking for the site root
				if (Host.VirtualPath == "/")
				{
					// app at the site root
					mappedPath = Host.PhysicalPath;
				}
				else
				{
					// unknown site root - don't point to app root to avoid double config inclusion
					mappedPath = Environment.SystemDirectory;
				}
			}
			else if (Host.IsVirtualPathAppPath(path))
			{
				// application path
				mappedPath = Host.PhysicalPath;
			}
			else if (Host.IsVirtualPathInApp(path, out isClientScriptPath))
			{
				if (isClientScriptPath)
				{
					mappedPath = Host.PhysicalClientScriptPath + path.Substring(Host.NormalizedClientScriptPath.Length);
				}
				else
				{
					// inside app but not the app path itself
					mappedPath = Host.PhysicalPath + path.Substring(Host.NormalizedVirtualPath.Length);
				}
			}
			else
			{
				// outside of app -- make relative to app path
				if (path.StartsWith("/", StringComparison.Ordinal))
				{
					mappedPath = Host.PhysicalPath + path.Substring(1);
				}
				else
				{
					mappedPath = Host.PhysicalPath + path;
				}
			}

			mappedPath = mappedPath.Replace('/', '\\');

			if (mappedPath.EndsWith("\\", StringComparison.Ordinal) && !mappedPath.EndsWith(":\\", StringComparison.Ordinal))
			{
				mappedPath = mappedPath.Substring(0, mappedPath.Length - 1);
			}

			return mappedPath;
		}

		public override void SendStatus(int statusCode, string statusDescription)
		{
			ResponseStatus = statusCode;
		}

		public override void SendKnownResponseHeader(int index, string value)
		{
			if (_headersSent)
			{
				return;
			}

			switch (index)
			{
				case HeaderServer:
				case HeaderDate:
				case HeaderConnection:
					// ignore these
					return;
				case HeaderAcceptRanges:
					if (value == "bytes")
					{
						// use this header to detect when we're processing a static file
						_specialCaseStaticFileHeaders = true;
						return;
					}
					break;
				case HeaderExpires:
				case HeaderLastModified:
					if (_specialCaseStaticFileHeaders)
					{
						// NOTE: Ignore these for static files. These are generated
						//       by the StaticFileHandler, but they shouldn't be.
						return;
					}
					break;
			}

			_responseHeadersBuilder.Append(GetKnownResponseHeaderName(index));
			_responseHeadersBuilder.Append(": ");
			_responseHeadersBuilder.Append(value);
			_responseHeadersBuilder.Append("\r\n");
		}

		public override void SendUnknownResponseHeader(string name, string value)
		{
			if (_headersSent)
			{
				return;
			}

			_responseHeadersBuilder.Append(name);
			_responseHeadersBuilder.Append(": ");
			_responseHeadersBuilder.Append(value);
			_responseHeadersBuilder.Append("\r\n");
		}

		public override void SendCalculatedContentLength(int contentLength)
		{
			if (!_headersSent)
			{
				_responseHeadersBuilder.Append("Content-Length: ");
				_responseHeadersBuilder.Append(contentLength.ToString(CultureInfo.InvariantCulture));
				_responseHeadersBuilder.Append("\r\n");
			}
		}

		public override bool HeadersSent()
		{
			return _headersSent;
		}

		public override bool IsClientConnected()
		{
			_connectionPermission.Assert();
			return Connection.Connected;
		}

		public override void CloseConnection()
		{
			_connectionPermission.Assert();
			Connection.Close();
		}

		public override void SendResponseFromMemory(byte[] data, int length)
		{
			if (length > 0)
			{
				var bytes = new byte[length];

				Buffer.BlockCopy(data, 0, bytes, 0, length);
				_responseBodyBytes.Add(bytes);
			}
		}

		public override void SendResponseFromFile(string filename, long offset, long length)
		{
			if (length == 0)
			{
				return;
			}

			FileStream f = null;
			try
			{
				f = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
				SendResponseFromFileStream(f, offset, length);
			}
			finally
			{
				if (f != null)
				{
					f.Close();
				}
			}
		}

		public override void SendResponseFromFile(IntPtr handle, long offset, long length)
		{
			if (length == 0)
			{
				return;
			}

			FileStream f = null;
			try
			{
				var sfh = new SafeFileHandle(handle, false);
				f = new FileStream(sfh, FileAccess.Read);
				SendResponseFromFileStream(f, offset, length);
			}
			finally
			{
				if (f != null)
				{
					f.Close();
				}
			}
		}

		private void SendResponseFromFileStream(Stream f, long offset, long length)
		{
			long fileSize = f.Length;

			if (length == -1)
			{
				length = fileSize - offset;
			}

			if (length == 0 || offset < 0 || length > fileSize - offset)
			{
				return;
			}

			if (offset > 0)
			{
				f.Seek(offset, SeekOrigin.Begin);
			}

			if (length <= MaxChunkLength)
			{
				var fileBytes = new byte[(int) length];
				var bytesRead = f.Read(fileBytes, 0, (int) length);
				SendResponseFromMemory(fileBytes, bytesRead);
			}
			else
			{
				var chunk = new byte[MaxChunkLength];
				var bytesRemaining = (int) length;

				while (bytesRemaining > 0)
				{
					var bytesToRead = (bytesRemaining < MaxChunkLength) ? bytesRemaining : MaxChunkLength;
					var bytesRead = f.Read(chunk, 0, bytesToRead);

					SendResponseFromMemory(chunk, bytesRead);
					bytesRemaining -= bytesRead;

					// flush to release keep memory
					if ((bytesRemaining > 0) && (bytesRead > 0))
					{
						FlushResponse(false);
					}
				}
			}
		}

		public override void FlushResponse(bool finalFlush)
		{
			_connectionPermission.Assert();

			if (!_headersSent)
			{
				Connection.WriteHeaders(ResponseStatus, _responseHeadersBuilder.ToString());
				_headersSent = true;
			}

			for (var i = 0; i < _responseBodyBytes.Count; i++)
			{
				var bytes = _responseBodyBytes[i];
				Connection.WriteBody(bytes, 0, bytes.Length);
			}

			_responseBodyBytes = new List<byte[]>();

			if (finalFlush)
			{
				Connection.Close();
			}
		}

		public override void EndOfRequest()
		{
			if (Connection != null)
			{
				var oldConnection = Connection;

				Connection = null;
				Server.OnRequestEnd(oldConnection);
			}
		}

		public void ChangeTarget(string path)
		{
			Path = path;
			FilePath = path;
			Url = (QueryString != null) ? (Path + "?" + QueryString) : Path;
			PathTranslated = MapPath(path);
		}
	}
}