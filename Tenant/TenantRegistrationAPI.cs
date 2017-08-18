using ManyWho.Flow.SDK.Utils;

namespace ManyWho.Flow.SDK.Tenant
{
    public class TenantRegistrationAPI : UserRegistrationAPI
    {
        public string tenantName
        {
            get;
            set;
        }

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
