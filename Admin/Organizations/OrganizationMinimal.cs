using System;

namespace ManyWho.Flow.SDK.Admin.Organizations
{
    public class OrganizationMinimal
    {
        /// <summary>
        /// The ID of the organization
        /// </summary>
        public Guid Id
        {
            get;
            set;
        }

        /// <summary>
        /// The friendly name of the organization
        /// </summary>
        public string Name
        {
            get;
            set;
        }
    }
}