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
        public List<Tenant> Tenants
        {
            get;
            set;
        } = new List<Tenant>();

        public class Tenant
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