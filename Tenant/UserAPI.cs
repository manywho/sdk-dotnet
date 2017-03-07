using System;
using System.Collections.Generic;

namespace ManyWho.Flow.SDK.Tenant
{
    public class UserAPI
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

        public string Role
        {
            get;
            set;
        }

        public string Username
        {
            get;
            set;
        }

        public DateTimeOffset? CreatedAt
        {
            get;
            set;
        }

        public List<UserTokenAPI> Tokens
        {
            get;
            set;
        }
    }
}
