using ManyWho.Flow.SDK.Notification;

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
        /// The notification to be sent to the user as part of the registration process.
        /// </summary>
        public NotificationRequestAPI notification
        {
            get;
            set;
        }
    }
}
