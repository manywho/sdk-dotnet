using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Recording
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class StatePlaybackRequestAPI
    {
        [DataMember]
        public string RuntimeAuthenticationToken
        {
            get;
            set;
        }
    }
}
