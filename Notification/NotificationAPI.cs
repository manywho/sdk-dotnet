using System;
using ManyWho.Flow.SDK.Tenant;

namespace ManyWho.Flow.SDK.Notification
{
    public class NotificationAPI : NotificationUpdateAPI
    {
        public TenantMinimalAPI Tenant
        {
            get;
            set;
        }

        public Guid UserId
        {
            get;
            set;
        }

        public string Content
        {
            get;
            set;
        }

        public string Subject
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        public DateTimeOffset CreatedAt
        {
            get;
            set;
        }
    }
}
