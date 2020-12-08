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
        public Guid nextMapElementId
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
        public DateTimeOffset? dateCommitted
        {
            get;
            set;
        }
        [DataMember]
        public string entryOutcomeId
        {
            get;
            set;
        }

        [DataMember]
        public string entryOutcomeDeveloperName
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
        
        [DataMember]
        public Dictionary<string, UserVoteAPI> userVotes
        {
            get;
            set;
        }

        /// <summary>
        /// It contains info about the list of stack frames valid for this state entry
        /// The last stack frame has MapElementId == null (to avoid redundancy) as this data can be taken from MapElementId
        /// </summary>
        [DataMember]
        public List<StackFrameInfoAPI> frames
        {
            get;
            set;
        }
    }
}
