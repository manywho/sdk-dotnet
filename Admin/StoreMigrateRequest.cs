using System;

namespace ManyWho.Flow.SDK.Admin
{
    public class StoreMigrateRequest
    {
        /// <summary>
        /// The id of the store where data will be migrated to
        /// </summary>
        public Guid StoreId
        {
            get;
            set;
        }
        
        /// <summary>
        /// A size of batch that will be used to save states during migration
        /// </summary>
        public int? BatchSize
        {
            get;
            set;
        }
    }
}