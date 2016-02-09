namespace Cassinipp.WebServer.Processors
{
	public class ClientScriptProcessor : AbstractProcessor
	{
        public override bool Intercept(Request request)
		{
			if (request.IsClientScriptPath)
			{
				request.Connection.WriteEntireResponseFromFile(
					request.Host.PhysicalClientScriptPath + request.Path.Substring(request.Host.NormalizedClientScriptPath.Length), false);
				return true;
			}

			return false;
		}
	}
}