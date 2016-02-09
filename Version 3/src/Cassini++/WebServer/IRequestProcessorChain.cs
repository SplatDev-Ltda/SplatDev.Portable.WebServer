using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiW.WebServer
{
    public interface IRequestProcessorChain : IRequestProcessor
    {
        IRequestProcessorChain Add(IRequestProcessor requestProcessor);
        void Clear();
    }
}
