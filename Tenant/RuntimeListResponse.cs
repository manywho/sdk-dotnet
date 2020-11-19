using System;
using ManyWho.Flow.SDK.Admin;

namespace ManyWho.Flow.SDK.Tenant
{
    public class TenantRuntimeListResponse
    {
        /// <summary>
        /// A unique identifier for the runtime
        /// </summary>
        public Guid Id
        {
            get;
            set;
        }

        /// <summary>
        /// A human-readable name for the runtime
        /// </summary>
        public string DeveloperName
        {
            get;
            set;
        }
        
        /// <summary>
        /// The latest version of the runtime the node is currently running.
        /// </summary>
        public string LatestVersion
        {
            get;
            set;
        }
    }
}