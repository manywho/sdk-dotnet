using System;

namespace ManyWho.Flow.SDK.Tenant
{
    public class UserTenantAPI
    {
        public string Id
        {
            get;
            set;
        }

        public string DeveloperName
        {
            get;
            set;
        }

        public string DeveloperSummary
        {
            get;
            set;
        }

        public DateTimeOffset? LastLoggedInAt
        {
            get;
            set;
        }
    }
}
