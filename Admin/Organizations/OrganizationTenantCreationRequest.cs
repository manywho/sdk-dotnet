using System;
using System.Collections.Generic;

namespace ManyWho.Flow.SDK.Admin.Organizations
{
    public class OrganizationTenantCreationRequest
    {
        /// <summary>
        /// The desired name of the tenant to create
        /// </summary>
        public string DeveloperName
        {
            get;
            set;
        }

        /// <summary>
        /// The users to add as members of the tenant
        /// </summary>
        public IEnumerable<User> Users
        {
            get;
            set;
        } = new List<User>();

        public class User
        {
            /// <summary>
            /// The ID of the user to invite, if the user already exists
            /// </summary>
            public Guid Id
            {
                get;
                set;
            }

            /// <summary>
            /// The email address of the user to invite, if the user already exists, or if a new user needs to be invited.
            /// </summary>
            public string Email
            {
                get;
                set;
            }

            /// <summary>
            /// The role the user should have in the tenant
            /// </summary>
            public string Role
            {
                get;
                set;
            }
        }
    }
}