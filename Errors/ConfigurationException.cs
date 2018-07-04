namespace ManyWho.Flow.SDK.Errors
{
    /// <summary>
    /// This exception type is used when a user-specified configuration causes a problem, and therefore won't be logged
    /// </summary>
    public class ConfigurationException : EngineException
    {
        public ConfigurationException(string message) : base(message)
        {

        }
    }
}
