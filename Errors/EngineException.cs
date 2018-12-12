using System;
using System.Net;

namespace ManyWho.Flow.SDK.Errors
{
    public class EngineException : Exception
    {
        public HttpStatusCode StatusCode { get; }

        public EngineException(string message, params object[] args) : this(string.Format(message, args))
        {
            
        }

        public EngineException(string message, HttpStatusCode statusCode = HttpStatusCode.BadRequest) : this(message, null, statusCode)
        {
            
        }

        public EngineException(string message, Exception exception, HttpStatusCode statusCode) : base(message, exception)
        {
            StatusCode = statusCode;
        }
    }
}
