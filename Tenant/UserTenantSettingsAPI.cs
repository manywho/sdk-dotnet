namespace ManyWho.Flow.SDK.Tenant
{
    public class UserTenantSettingsAPI
    {
        public UserTenantSettingsNotificationsAPI Notifications
        {
            get;
            set;
        }

        public bool EnabledSSO
        {
            get;
            set;
        }
    }
}
