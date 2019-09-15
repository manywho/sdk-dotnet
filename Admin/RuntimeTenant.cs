using System;

namespace ManyWho.Flow.SDK.Admin
{
    public class RuntimeTenant
    {
        /// <summary>
        /// The unique identifier for the tenant
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
        /// The timestamp of when the tenant was first associated with the runtime
        /// </summary>
        public DateTimeOffset AssociatedAt
        {
            get;
            set;
        }
    }
}