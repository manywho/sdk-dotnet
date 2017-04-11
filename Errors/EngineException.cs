using System;
using System.Net;

namespace ManyWho.Flow.SDK.Errors
{
    public class EngineException : Exception
    {
        public HttpStatusCode StatusCode { get; private set; }

        public EngineException(string message) : this(message, HttpStatusCode.BadRequest)
        {

        }

        public EngineException(string message, HttpStatusCode statusCode) : this(message, null, statusCode)
        {
            
        }

        public EngineException(string message, Exception exception, HttpStatusCode statusCode) : base(message, exception)
        {
            StatusCode = statusCode;
        }
    }
}
