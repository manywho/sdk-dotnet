using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Tenant
{
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
    }
}
