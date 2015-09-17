using System;
using ManyWho.Flow.SDK.Utils;

namespace ManyWho.Flow.SDK.Tenant
{
    public class TenantRegistrationAPI : UserRegistrationAPI
    {
        public string subdomain
        {
            get;
            set;
        }

        public NotificationRequestAPI notification
        {
            get;
            set;
        }
    }
}
