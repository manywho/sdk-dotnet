using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ManyWho.Flow.SDK.Admin
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RuntimeStatus
    {
        /// <summary>
        /// The status of the runtime or node is currently not known
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown = 0,

        /// <summary>
        /// The runtime or node is currently the leader
        /// </summary>
        [EnumMember(Value = "leader")]
        Leader,

        /// <summary>
        /// The runtime or node is currently online
        /// </summary>
        [EnumMember(Value = "online")]
        Online,

        /// <summary>
        /// The runtime or node is currently offline
        /// </summary>
        [EnumMember(Value = "offline")]
        Offline
    }
}