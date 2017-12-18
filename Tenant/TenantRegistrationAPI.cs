using ManyWho.Flow.SDK.Notification;
using ManyWho.Flow.SDK.Utils;

namespace ManyWho.Flow.SDK.Tenant
{
    public class TenantRegistrationAPI : UserRegistrationAPI
    {
        /// <summary>
        /// The name of the tenant to create
        /// </summary>
        public string tenantName
        {
            get;
            set;
        }

        /// <summary>
        /// An optional, globally unique subdomain to reserve for this tenant
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
