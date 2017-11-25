using System;
using System.Net;

namespace ManyWho.Flow.SDK.Errors
{
    public class ConfigurationException : EngineException
    {
        public Guid Element
        {
            get;
            set;
        }
        
        public ConfigurationException(string message) : base(message, HttpStatusCode.BadRequest)
        {

        }

        public ConfigurationException(string message, Guid element) : base(message)
        {
            Element = element;
        }
    }
}
