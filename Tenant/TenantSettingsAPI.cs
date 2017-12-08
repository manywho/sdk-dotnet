using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ManyWho.Flow.SDK.Tenant
{
    /// <summary>
    /// Settings that are specific to features used in the tenant
    /// </summary>
    public class TenantSettingsAPI
    {
        /// <summary>
        /// The version of the platform your tenant’s flows will run using - can be one of `rolling` to always use the 
        /// latest version, or `monthly` for a monthly-released, 1-month delayed version (based on `rolling`)
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public ReleaseCycle ReleaseCycle
        {
            get;
            set;
        }
        
        public bool FormatValues
        {
            get;
            set;
        }
    }
}
