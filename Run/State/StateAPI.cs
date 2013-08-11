using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Flow;
using ManyWho.Flow.SDK.Run;

namespace ManyWho.Flow.SDK.Run.State
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class StateAPI
    {
        [DataMember]
        public String id
        {
            get;
            set;
        }

        [DataMember]
        public FlowIdAPI currentFlowId
        {
            get;
            set;
        }

        [DataMember]
        public String currentMapElementId
        {
            get;
            set;
        }

        [DataMember]
        public String runningUserId
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isCommitted
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isCompleted
        {
            get;
            set;
        }

        [DataMember]
        public Boolean logState
        {
            get;
            set;
        }
    }
}
