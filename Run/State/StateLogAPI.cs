using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run.State
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class StateLogAPI
    {
        [DataMember]
        public List<StateLogEntryAPI> stateLogEntries
        {
            get;
            set;
        }
    }
}