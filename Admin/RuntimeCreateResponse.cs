using System;
using System.Collections.Generic;
using ManyWho.Flow.SDK.Security;

namespace ManyWho.Flow.SDK.Admin
{
    public class RuntimeCreateResponse
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
        /// When the runtime was created
        /// </summary>
        public DateTimeOffset CreatedAt
        {
            get;
            set;
        }

        /// <summary>
        /// The user who created the runtime
        /// </summary>
        public BuilderWhoAPI CreatedBy
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
        /// A one-time token that the runtime must be configured with for installation
        /// </summary>
        public string InstallationToken
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
        /// A list of all the tenants currently associated with this runtime
        /// </summary>
        public IEnumerable<RuntimeTenant> Tenants
        {
            get;
            set;
        } = new List<RuntimeTenant>();
    }
}