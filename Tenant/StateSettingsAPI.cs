using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ManyWho.Flow.SDK.Tenant
{
    public enum StateReportingAuthentication
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "basic")]
        Basic,
        [EnumMember(Value = "clientcredentials")]
        ClientCredentials
    }

    /// <summary>
    /// Settings used for state persistence and reporting
    /// </summary>
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class StateSettingsAPI
    {
        /// <summary>
        /// The URI to send all state updates to, which must implement our Reporting API interface. More details 
        /// on that can be found [here](https://github.com/manywho/reporting)
        /// </summary>
        [DataMember]
        public string endpoint
        {
            get;
            set;
        }

        /// <summary>
        /// The type of authentication that should be used when sending data to the configured endpoint
        /// </summary>
        [DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public StateReportingAuthentication authentication
        {
            get;
            set;
        }

        /// <summary>
        /// Username or Client Id, if authentication is set to Basic or ClientCredentials
        /// </summary>
        [DataMember]
        public string username
        {
            get;
            set;
        }

        /// <summary>
        /// Password or Client Secret, if authentication is set to Basic or ClientCredentials
        /// </summary>
        [DataMember]
        public string password
        {
            get;
            set;
        }

        /// <summary>
        /// OAuth token endpoint for ClientCredentials based authentication
        /// </summary>
        [DataMember]
        public string tokenEndpoint
        {
            get;
            set;
        }
    }
}
