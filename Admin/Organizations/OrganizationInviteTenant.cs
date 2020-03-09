using ManyWho.Flow.SDK.Tenant;

namespace ManyWho.Flow.SDK.Admin.Organizations
{
    public class OrganizationInviteTenant : OrganizationInvite
    {
        /// <summary>
        /// The tenant that is invited to join the organization
        /// </summary>
        public TenantMinimalAPI Tenant
        {
            get;
            set;
        }
    }
}