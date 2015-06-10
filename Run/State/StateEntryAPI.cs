using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Flow;

namespace ManyWho.Flow.SDK.Run.State
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class StateEntryAPI
    {
        [DataMember]
        public String id
        {
            get;
            set;
        }

        [DataMember]
        public FlowIdAPI flowId
        {
            get;
            set;
        }

        [DataMember]
        public String flowDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public String mapElementId
        {
            get;
            set;
        }

        [DataMember]
        public String mapElementDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public DateTime dateCommitted
        {
            get;
            set;
        }

        [DataMember]
        public List<StateValueAPI> values
        {
            get;
            set;
        }

        [DataMember]
        public List<UserInteractionAPI> userInteractions
        {
            get;
            set;
        }
    }
}
