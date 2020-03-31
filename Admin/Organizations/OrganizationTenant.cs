using System;
using System.Collections.Generic;
using ManyWho.Flow.SDK.Security;
using ManyWho.Flow.SDK.Tenant;
using Newtonsoft.Json;

namespace ManyWho.Flow.SDK.Admin.Organizations
{
    public class OrganizationTenant
    {
        /// <summary>
        /// The ID of the tenant
        /// </summary>
        public Guid Id
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the tenant
        /// </summary>
        public string DeveloperName
        {
            get;
            set;
        }

        /// <summary>
        /// The ID of the tenant's parent, if this is a subtenant
        /// </summary>
        [JsonIgnore]
        public Guid? ParentId
        {
            get;
            set;
        }

        /// <summary>
        /// When the tenant was added into the organization
        /// </summary>
        public DateTimeOffset? AddedAt
        {
            get;
            set;
        }

        /// <summary>
        /// Who added the tenant into the organization
        /// </summary>
        public BuilderWhoAPI AddedBy
        {
            get;
            set;
        }

        /// <summary>
        /// Any subtenants that belong to the tenant
        /// </summary>
        public List<TenantMinimalAPI> Subtenants
        {
            get;
            set;
        } = new List<TenantMinimalAPI>();
    }
}