using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Flow;
using ManyWho.Flow.SDK.Run.State;

namespace ManyWho.Flow.SDK.Run.Flow
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class FlowStackFrameAPI
    {

        [DataMember]
        public FlowIdAPI FlowId
        {
            get;
            set;
        }
        
        [DataMember]
        public Guid? MapElementId
        {
            get;
            set;
        }

        [DataMember]
        public string MapElementDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public string RunningUserId
        {
            get;
            set;
        }
        
        [DataMember]
        public StateEntryAPI PrecommitStateEntry
        {
            get;
            set;
        }
        
        [DataMember]
        public List<StateValueAPI> Values
        {
            get;
            set;
        }
    }
} 