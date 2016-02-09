using System;
using System.Globalization;

namespace PiW.WebServer.Processors
{
    public class RestrictedDirectoryProcessor : AbstractProcessor
	{
		private static readonly string[] RestrictedDirs = new []
		                                                  	{
		                                                  		"/bin",
		                                                  		"/app_browsers",
		                                                  		"/app_code",
		                                                  		"/app_data",
		                                                  		"/app_localresources",
		                                                  		"/app_globalresources",
		                                                  		"/app_webreferences"
		                                                  	};

        public override bool Intercept(Request request)
		{
			var p = CultureInfo.InvariantCulture.TextInfo.ToLower(request.Path);

			if (request.Host.IsVirtualPathRoot)
			{
				p = p.Substring(request.Host.VirtualPath.Length);
			}

			var isRestrictedDirectory = IsRestrictedDirectory(p);

			if (isRestrictedDirectory)
			{
				request.Connection.WriteErrorAndClose(403);
			}

			return isRestrictedDirectory;
		}

		private static bool IsRestrictedDirectory(string p)
		{
			foreach (var dir in RestrictedDirs)
			{
				if (p.StartsWith(dir, StringComparison.Ordinal))
				{
					if (p.Length == dir.Length || p[dir.Length] == '/')
					{
						return true;
					}
				}
			}

			return false;
		}
	}
}