using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ManyWho.Flow.SDK.Tenant
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class TenantSettingsAPI
    {
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember]
        public EngineVersion engineVersion
        {
            get;
            set;
        }

        public enum EngineVersion
        {
            [EnumMember(Value = "current")]
            Current = 0,
            [EnumMember(Value = "unstable")]
            Unstable = 1
        }

        [DataMember]
        public bool formatValues
        {
            get;
            set;
        }
    }
}
