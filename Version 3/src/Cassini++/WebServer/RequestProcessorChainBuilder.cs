using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using PiW.WebServer.Processors;

namespace PiW.WebServer
{
    public class RequestProcessorChainBuilder
    {
        private static readonly RequestProcessorChainBuilder _current = new RequestProcessorChainBuilder();

        private RequestProcessorChainBuilder()
        {
        }

        public Func<IRequestProcessorChain> Build = () => new RequestProcessorChain()
            .Add(new Post100Processor())
            .Add(new ClientScriptProcessor())
            .Add(new RestrictedDirectoryProcessor())
            .Add(new DirectoryListingProcessor())
            .Add(new HttpRuntimeProcessor());

        public static RequestProcessorChainBuilder Current
        {
            get { return _current; }
        }
    }
}
