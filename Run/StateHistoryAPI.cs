using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class StateHistoryAPI
    {
        [DataMember]
        public List<StateHistoryEntryAPI> entries
        {
            get;
            set;
        }
    }
}