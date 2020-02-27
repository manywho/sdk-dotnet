using System;
using ManyWho.Flow.SDK.Admin.Organizations;

namespace ManyWho.Flow.SDK.Tenant
{
    public class UserTenantAPI
    {
        public string Id
        {
            get;
            set;
        }

        public string DeveloperName
        {
            get;
            set;
        }

        public string DeveloperSummary
        {
            get;
            set;
        }

        public DateTimeOffset? ExpiresAt
        {
            get;
            set;
        }

        public bool IsExpired
        {
            get;
            set;
        }

        public DateTimeOffset? LastLoggedInAt
        {
            get;
            set;
        }

        public UserTenantSettingsAPI Settings
        {
            get;
            set;
        }

        /// <summary>
        /// The organization this tenant belongs to, if any
        /// </summary>
        public OrganizationMinimal Organization
        {
            get;
            set;
        }
    }
}
