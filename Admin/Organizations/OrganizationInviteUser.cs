using ManyWho.Flow.SDK.Security;

namespace ManyWho.Flow.SDK.Admin.Organizations
{
    public class OrganizationInviteUser : OrganizationInvite
    {
        /// <summary>
        /// The user that is invited to join the organization
        /// </summary>
        public BuilderWhoAPI User
        {
            get;
            set;
        }
    }
}