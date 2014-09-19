using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManyWho.Flow.SDK.Utils;

namespace ManyWho.Flow.SDK.Tenant
{
    public class TenantRegistrationAPI
    {
        public String firstName
        {
            get;
            set;
        }

        public String lastName
        {
            get;
            set;
        }

        public String email
        {
            get;
            set;
        }

        public String username
        {
            get;
            set;
        }

        public String password
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
