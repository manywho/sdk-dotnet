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
        public string id
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
        public string flowDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public string mapElementId
        {
            get;
            set;
        }

        [DataMember]
        public string mapElementDeveloperName
        {
            get;
            set;
        }
        
        [DataMember]
        public Guid? authenticatingServiceElementId
        {
            get;
            set;
        }

        [DataMember]
        public DateTimeOffset dateCommitted
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
