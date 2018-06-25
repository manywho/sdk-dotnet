using System;

namespace ManyWho.Flow.SDK.Tenant
{
    public class ExternalStorageSettingsAPI
    {
        /// <summary>
        /// Whether to store states using the External Storage API or not
        /// </summary>
        public bool EnableStates
        {
            get;
            set;
        }
        
        /// <summary>
        /// The ID of the store to use for all content in the tenant
        /// </summary>
        public Guid? GlobalStoreId
        {
            get;
            set;
        }
    }
}