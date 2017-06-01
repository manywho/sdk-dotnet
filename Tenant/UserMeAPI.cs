using System;
using System.Collections.Generic;

namespace ManyWho.Flow.SDK.Tenant
{
    public class UserMeAPI
    {
        public Guid Id
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public bool Verified
        {
            get;
            set;
        }

        public DateTimeOffset? CreatedAt
        {
            get;
            set;
        }

        public List<UserTenantAPI> Tenants
        {
            get;
            set;
        }
    }
}
