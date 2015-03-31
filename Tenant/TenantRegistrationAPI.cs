using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManyWho.Flow.SDK.Utils;

namespace ManyWho.Flow.SDK.Tenant
{
    public class TenantRegistrationAPI
    {
        public string firstName
        {
            get;
            set;
        }

        public string lastName
        {
            get;
            set;
        }

        public string email
        {
            get;
            set;
        }

        public string username
        {
            get;
            set;
        }

        public string password
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
