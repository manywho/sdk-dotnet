using System;
using ManyWho.Flow.SDK.Security;

namespace ManyWho.Flow.SDK.Admin.Organizations
{
    public class OrganizationUser
    {
        /// <summary>
        /// The ID of the user
        /// </summary>
        public Guid Id
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the user
        /// </summary>
        public string Email
        {
            get;
            set;
        }

        /// <summary>
        /// The first name of the user
        /// </summary>
        public string FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// The last name of the user
        /// </summary>
        public string LastName
        {
            get;
            set;
        }

        /// <summary>
        /// The user's role in the organization
        /// </summary>
        public string Role
        {
            get;
            set;
        }

        /// <summary>
        /// When the user was added into the organization
        /// </summary>
        public DateTimeOffset? AddedAt
        {
            get;
            set;
        }

        /// <summary>
        /// Who added the user into the organization
        /// </summary>
        public BuilderWhoAPI AddedBy
        {
            get;
            set;
        }
    }
}