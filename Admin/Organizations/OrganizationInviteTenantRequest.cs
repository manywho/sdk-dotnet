using System;

namespace ManyWho.Flow.SDK.Admin.Organizations
{
    public class OrganizationInviteTenantRequest
    {
        public string DeveloperName
        {
            get;
            set;
        }

        public Guid Id
        {
            get;
            set;
        }
    }
}