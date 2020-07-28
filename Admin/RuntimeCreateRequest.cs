using System;
using System.Collections.Generic;

namespace ManyWho.Flow.SDK.Admin
{
    public class RuntimeCreateRequest
    {
        /// <summary>
        /// The name to use for the created runtime
        /// </summary>
        public string DeveloperName
        {
            get;
            set;
        }

        /// <summary>
        /// Any tenants to associate with the runtime
        /// </summary>
        public List<RuntimeCreateRequestTenant> Tenants
        {
            get;
            set;
        } = new List<RuntimeCreateRequestTenant>();

        public class RuntimeCreateRequestTenant
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