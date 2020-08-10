using System;
using System.Collections.Generic;

namespace ManyWho.Flow.SDK.Admin
{
    public class RuntimeUpdateRequest
    {
        /// <summary>
        /// The new name to use for the runtime
        /// </summary>
        public string DeveloperName
        {
            get;
            set;
        }

        /// <summary>
        /// Any tenants to associate with the runtime
        /// </summary>
        public List<RuntimeUpdateRequestTenant> Tenants
        {
            get;
            set;
        } = new List<RuntimeUpdateRequestTenant>();

        public class RuntimeUpdateRequestTenant
        {
            /// <summary>
            /// The unique identifier for the tenant
            /// </summary>
            public Guid Id
            {
                get;
                set;
            }
        }
    }
}