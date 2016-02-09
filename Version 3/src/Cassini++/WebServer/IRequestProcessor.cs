namespace PiW.WebServer
{
	public interface IRequestProcessor
	{
        /// <summary>
        /// Gets called before request headers are parsed.
        /// </summary>
        /// <param name="request">Raw request data to be processed.</param>
        void Pre(Request request);

        /// <summary>
        /// Processes the request. Further request processing can be canceled if <i>true</i> is
        /// returned. Note that <see cref="Pre()"/> and <see cref="Post()"/> processing steps are invoked
        /// no mather what you return.
        /// </summary>
        /// <param name="request">Request with parsed request data to be processed.</param>
        /// <returns><i>True</i> to cancel processor chain otherwise <i>false</i>.</returns>
		bool Intercept(Request request);

        /// <summary>
        /// Gets called after request is processed
        /// </summary>
        /// <param name="request">Request with parsed request data after beeing processed by <see cref="Intercept()" /> step.</param>
        void Post(Request request);
	}
}