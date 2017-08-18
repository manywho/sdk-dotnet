using System;

namespace ManyWho.Flow.SDK.Run.Elements.Config
{
    public class ServiceMessageAPI
    {
        public string AuthorizationToken
        {
            get;
            set;
        }

        public DateTimeOffset CreatedAt
        {
            get;
            set;
        }

        public ServiceRequestAPI Request
        {
            get;
            set;
        }
   }
}