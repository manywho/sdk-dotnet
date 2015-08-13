using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Tenant
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class StateSettingsAPI
    {
        [DataMember]
        public string endpoint
        {
            get;
            set;
        }

        [DataMember]
        public bool persistToDatabase
        {
            get;
            set;
        } = true;
    }
}
