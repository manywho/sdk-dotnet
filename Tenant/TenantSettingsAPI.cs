using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ManyWho.Flow.SDK.Tenant
{
    public class TenantSettingsAPI
    {
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
