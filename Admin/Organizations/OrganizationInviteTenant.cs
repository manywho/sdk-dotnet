using System;
using ManyWho.Flow.SDK.Security;
using ManyWho.Flow.SDK.Tenant;

namespace ManyWho.Flow.SDK.Admin.Organizations
{
    public class OrganizationInviteTenant
    {
        /// <summary>
        /// The organization that sent the invitation
        /// </summary>
        public OrganizationMinimal Organization
        {
            get;
            set;
        }

        /// <summary>
        /// The tenant that is invited to join the organization
        /// </summary>
        public TenantMinimalAPI Tenant
        {
            get;
            set;
        }

        /// <summary>
        /// The user who either accepted or rejected this invitation
        /// </summary>
        public BuilderWhoAPI CompletedBy
        {
            get;
            set;
        }

        /// <summary>
        /// When the invitation was either accepted or rejected
        /// </summary>
        public DateTimeOffset? CompletedAt
        {
            get;
            set;
        }

        /// <summary>
        /// The user who sent the invitation
        /// </summary>
        public BuilderWhoAPI InvitedBy
        {
            get;
            set;
        }

        /// <summary>
        /// When the invitation was sent
        /// </summary>
        public DateTimeOffset InvitedAt
        {
            get;
            set;
        }

        /// <summary>
        /// The current status of the invitation. Can be one of "invited", "accepted" or "rejected".
        /// </summary>
        public string Status
        {
            get;
            set;
        }
    }
}