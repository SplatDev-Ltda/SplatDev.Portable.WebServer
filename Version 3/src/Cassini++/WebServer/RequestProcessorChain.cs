using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using PiW.WebServer.Processors;

namespace PiW.WebServer
{
    public class RequestProcessorChain : IRequestProcessorChain
    {
        private List<IRequestProcessor> RequestProcessors { get; set; }

        public RequestProcessorChain()
        {
            RequestProcessors = new List<IRequestProcessor>();
        }

        public IRequestProcessorChain Add(IRequestProcessor requestProcessor)
        {
            RequestProcessors.Add(requestProcessor);

            return this;
        }

        public void Clear()
        {
            RequestProcessors.Clear();
        }

        public void Pre(Request request)
        {
            InvokeProcessors(processor => processor.Pre(request));
        }

        public bool Intercept(Request request)
        {
            foreach (var processor in RequestProcessors)
            {
                if (processor.Intercept(request))
                {
                    return true;
                }
            }

            return false;
        }

        public void Post(Request request)
        {
            InvokeProcessors(processor => processor.Post(request));
        }

        private void InvokeProcessors(Action<IRequestProcessor> function)
        {
            foreach (var processor in RequestProcessors)
            {
                function(processor);
            }
        }
    }
}
