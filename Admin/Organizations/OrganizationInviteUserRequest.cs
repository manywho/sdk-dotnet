using System;

namespace ManyWho.Flow.SDK.Admin.Organizations
{
    public class OrganizationInviteUserRequest
    {
        /// <summary>
        /// The email of the user to send the invite to
        /// </summary>
        public string Email
        {
            get;
            set;
        }

        /// <summary>
        /// The ID of the user to send the invite to
        /// </summary>
        public Guid Id
        {
            get;
            set;
        }
    }
}