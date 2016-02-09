namespace PiW.WebServer.Processors
{
    public class Post100Processor : AbstractProcessor
	{
        public override bool Intercept(Request request)
		{
			// 100 response to POST
			if (request.Verb == "POST" && request.ContentLength > 0 && request.PreloadedContentLength < request.ContentLength)
			{
				request.Connection.Write100Continue();
			}

			return false;
		}
	}
}