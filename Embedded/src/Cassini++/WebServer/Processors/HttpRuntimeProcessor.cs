using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Web;

namespace Cassinipp.WebServer.Processors
{
    public class HttpRuntimeProcessor : AbstractProcessor
    {
        public override bool Intercept(Request request)
        {
            request.PrepareResponse();

            // Hand the processing over to HttpRuntime
            HttpRuntime.ProcessRequest(request);

            return true;
        }
    }
}
