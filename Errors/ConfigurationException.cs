using System;
using System.Net;

namespace ManyWho.Flow.SDK.Errors
{
    /// <summary>
    /// This exception type is used when a user-specified configuration causes a problem, and therefore won't be logged
    /// </summary>
    public class ConfigurationException : EngineException
    {
        public Guid Element
        {
            get;
            set;
        }
        
        public ConfigurationException(string message, HttpStatusCode statusCode = HttpStatusCode.BadRequest) : base(message, statusCode)
        {
        }
        
        public ConfigurationException(string message) : base(message)
        {

        }

        public ConfigurationException(string message, Guid element) : base(message)
        {
            Element = element;
        }
    }
}
