using System;
using ManyWho.Flow.SDK.Security;
using ManyWho.Flow.SDK.Tenant;

namespace ManyWho.Flow.SDK.Admin.Organizations
{
    public class OrganizationInviteTenant
    {
        public OrganizationMinimal Organization
        {
            get;
            set;
        }

        public TenantMinimalAPI Tenant
        {
            get;
            set;
        }

        public BuilderWhoAPI InvitedBy
        {
            get;
            set;
        }

        public DateTimeOffset InvitedAt
        {
            get;
            set;
        }

        public string Status
        {
            get;
            set;
        }
    }
}