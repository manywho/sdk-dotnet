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

        /// <summary>
        /// The subdomain to register for the tenant
        /// </summary>
        public string subdomain
        {
            get;
            set;
        }

        /// <summary>
        /// The notification to be sent to the user as part of the registration process.
        /// </summary>
        public NotificationRequestAPI notification
        {
            get;
            set;
        }
    }
}
