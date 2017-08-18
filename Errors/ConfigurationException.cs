using System.Net;

namespace ManyWho.Flow.SDK.Errors
{
    public class ConfigurationException : EngineException
    {
        public ConfigurationException(string message) : base(message, HttpStatusCode.BadRequest)
        {

        }
    }
}
