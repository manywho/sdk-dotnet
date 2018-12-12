using System;

namespace ManyWho.Flow.SDK
{
    public class ManyWhoPluginException : Exception
    {
        public ManyWhoPluginException()
        {
        }

        public ManyWhoPluginException(string message)
            : base(message)
        {
        }

        public ManyWhoPluginException(string message, Exception inner)
            : base(message, inner)
        {
        }

        public override string Message
        {
            get
            {
                return CleanExceptionMessage(base.Message);
            }
        }

        private string CleanExceptionMessage(string message)
        {
            if (message != null)
            {
                // Clean up argument null exceptions
                if (message.StartsWith("Exception: "))
                {
                    message = message.Substring("Exception: ".Length);
                }

                if (message.IndexOf("Parameter name: ") > 0)
                {
                    message = message.Substring(0, message.IndexOf("Parameter name: ")).Trim();
                }
            }

            return message;
        }
    }
}
