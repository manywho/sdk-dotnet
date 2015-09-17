using System;
using System.Net;

namespace ManyWho.Flow.SDK.Errors
{
    public class EngineException : Exception
    {
        public HttpStatusCode StatusCode { get; private set; }

        public EngineException(string message, HttpStatusCode statusCode) : base(message)
        {
            StatusCode = statusCode;
        }
    }
}
