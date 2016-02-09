using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace Cassinipp.Processors
{
    public class W3CLogger : AbstractProcessor
    {
        private static readonly Object LockObject = new Object();

        private string RemoteIP { get; set; }

        public string LogDirectory { get; set; }
        public bool Enabled { get; set; }

        public override void Pre(Request request)
        {
            // Save request values
            RemoteIP = request.Connection.RemoteIP;
        }

        public override void Post(Request request)
        {
            if (String.IsNullOrEmpty(LogDirectory) || !Enabled)
            {
                return;
            }

            StreamWriter writer = null;
            lock (LockObject)
            {
                try
                {
                    var now = DateTime.UtcNow;

                    var logDir = LogDirectory.EndsWith("\\") ? LogDirectory : LogDirectory + "\\";
                    var logFile = logDir + now.ToString("yyyy-dd-MM");

                    writer = new StreamWriter(File.Open(logDir, FileMode.Append, FileAccess.Write, FileShare.Read), Encoding.ASCII);

                    if (writer.BaseStream.Position == 0)
                    {
                        // Write header

                        writer.WriteLine("#Software: " + Version.FullName);
                        writer.WriteLine("#Version: 1.0"); // W3C Log version
                        writer.WriteLine("#Date: " + DateTime.UtcNow.ToShortDateString());
                        writer.WriteLine("#Fields: date time c-ip cs-method cs-uri-stem sc-status");
                    }

                    writer.WriteLine("{0:d} {0:T} {1} {2} {3} {4}",
                        now,
                        RemoteIP,
                        request.Verb,
                        request.Url,
                        request.ResponseStatus);
                }
                catch { 
                    // Bad catch all block!
                }
                finally
                {
                    try
                    {
                        if (writer != null)
                        {
                            writer.Close();
                        }
                    }
                    catch 
                    {
                        // Bad catch all block 2!
                    }
                }
            }
        }
    }
}
