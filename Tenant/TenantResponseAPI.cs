using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Admin.Organizations;

/*!

Copyright 2013 Manywho, Inc.

Licensed under the Manywho License, Version 1.0 (the "License"); you may not use this
file except in compliance with the License.

You may obtain a copy of the License at: http://manywho.com/sharedsource

Unless required by applicable law or agreed to in writing, software distributed under
the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the specific language governing
permissions and limitations under the License.

*/

namespace ManyWho.Flow.SDK.Tenant
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class TenantResponseAPI : TenantRequestAPI
    {
        /// <summary>
        /// The unique identifier for the tenant. The unique identifier is assigned by the platform.
        /// </summary>
        [DataMember]
        public string id
        {
            get;
            set;
        }

        /// <summary>
        /// A timestamp of when the tenant should expire
        /// </summary>
        [DataMember]
        public DateTimeOffset? expiresAt
        {
            get;
            set;
        }

        /// <summary>
        /// The list of sub tenants associated with this parent tenant.
        /// </summary>
        [DataMember]
        public List<TenantResponseAPI> subTenants
        {
            get;
            set;
        }

        /// <summary>
        /// The organization this tenant belongs to, if any
        /// </summary>
        [DataMember]
        public OrganizationMinimal Organization
        {
            get;
            set;
        }
    }
}
