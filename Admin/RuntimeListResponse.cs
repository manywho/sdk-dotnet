using System;

namespace ManyWho.Flow.SDK.Admin
{
    public class RuntimeListResponse
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
        /// The number of healthy nodes currently part of the runtime. This count is determined from the number of nodes
        /// that have reported a status in the last few minutes.
        /// </summary>
        public int NumberOfHealthyNodes
        {
            get;
            set;
        }

        /// <summary>
        /// The number of tenants currently associated with this runtime
        /// </summary>
        public int NumberOfTenants
        {
            get;
            set;
        }

        /// <summary>
        /// The timestamp of the latest report received from any node in the runtime
        /// </summary>
        public DateTimeOffset? ReportedAt
        {
            get;
            set;
        }

        /// <summary>
        /// The current status of the runtime, determined by the last time a report was received from any node
        /// </summary>
        public RuntimeStatus Status
        {
            get;
            set;
        }

        /// <summary>
        /// The URI used to access the runtime. This could be an internal, private or public URI.
        /// </summary>
        public string Uri
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