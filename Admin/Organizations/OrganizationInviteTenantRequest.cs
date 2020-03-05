using System;

namespace ManyWho.Flow.SDK.Admin.Organizations
{
    public class OrganizationInviteTenantRequest
    {
        /// <summary>
        /// The name of the tenant to send the invite to
        /// </summary>
        public string DeveloperName
        {
            get;
            set;
        }

        /// <summary>
        /// The ID of the tenant to send the invite to
        /// </summary>
        public Guid Id
        {
            get;
            set;
        }
    }
}