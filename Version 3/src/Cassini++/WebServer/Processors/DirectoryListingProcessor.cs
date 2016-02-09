using System;
using System.IO;

namespace PiW.WebServer.Processors
{
    public class DirectoryListingProcessor : AbstractProcessor
    {
        private static readonly string[] DefaultFileNames = Properties.Settings.Default["DefaultDocs"].ToString().Split(',');

        public override bool Intercept(Request request)
        {
            if (request.Verb != "GET")
            {
                return false;
            }

            var dirPathTranslated = request.PathTranslated;

            if (request.PathInfo.Length > 0)
            {
                // directory path can never have pathInfo
                dirPathTranslated = request.MapPath(request.Path);
            }

            if (!Directory.Exists(dirPathTranslated))
            {
                return false;
            }

            // have to redirect /foo to /foo/ to allow relative links to work
            if (!request.Path.EndsWith("/", StringComparison.Ordinal))
            {
                var newPath = request.Path + "/";
                var location = "Location: " + request.UrlEncodeRedirect(newPath) + "\r\n";
                var body = "<html><head><title>Object moved</title></head><body>\r\n" +
                              "<h2>Object moved to <a href='" + newPath + "'>here</a>.</h2>\r\n" +
                              "</body></html>\r\n";

                request.Connection.WriteEntireResponseFromString(302, location, body, false);

                return true;
            }

            // check for the default file
            foreach (string filename in DefaultFileNames)
            {
                if (File.Exists(request.MapPath(request.Path + "\\" + filename)))
                {
                    // pretend the request is for the default file path
                    request.ChangeTarget(request.Path + filename);

                    return false; // go through normal processing
                }
                //check if app is MVC and return home
                if (request.AppType == Utilities.AppType.MVC)
                {
                    request.ChangeTarget(request.Server.MVCHomePath);
                    return false;
                }
            }

            // get all files and subdirs
            FileSystemInfo[] infos = null;
            try
            {
                infos = (new DirectoryInfo(dirPathTranslated)).GetFileSystemInfos();
            }
            catch
            {
            }

            // determine if parent is appropriate
            string parentPath = null;

            if (request.Path.Length > 1)
            {

                var i = request.Path.LastIndexOf('/', request.Path.Length - 2);

                parentPath = (i > 0) ? request.Path.Substring(0, i) : "/";
                if (!request.Host.IsVirtualPathInApp(parentPath))
                {
                    parentPath = null;
                }
            }

            request.Connection.WriteEntireResponseFromString(200, "Content-type: text/html; charset=utf-8\r\n",
                                                             Messages.FormatDirectoryListing(request.Path, parentPath, infos),
                                                             false);
            return true;
        }
    }
}