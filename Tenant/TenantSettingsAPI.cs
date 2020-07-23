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
        /// Whether to disable the logging of service invoker requests, reponses and failures. They are helpful when
        /// debugging, and a requirement for a tenant's flows to be tested using Reflow, but having the platform store
        /// them might be against a customer's compliance rules.
        /// </summary>
        public bool DisableServiceInvokerLogging
        {
            get;
            set;
        }

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
        
        public bool UseRegionalRedirectUris 
        { 
            get; 
            set; 
        }
    }
}
