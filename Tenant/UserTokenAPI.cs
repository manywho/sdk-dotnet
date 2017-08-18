using System;

namespace ManyWho.Flow.SDK.Tenant
{
    public class UserTokenAPI
    {
        public Guid ServiceId
        {
            get;
            set;
        }

        public DateTimeOffset CreatedAt
        {
            get;
            set;
        }

        public DateTimeOffset UpdatedAt
        {
            get;
            set;
        }
    }
}
