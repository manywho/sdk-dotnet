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

        /// <summary>
        /// The id of the flow associated with this stack frame
        /// </summary>
        [DataMember]
        public FlowIdAPI FlowId
        {
            get;
            set;
        }
        
        /// <summary>
        /// If this frame is the current frame, this property contains the id of the current map element.
        /// If this frame refers to one of the parent frames, this property contains the id of a Subflow map element that was the entry point to the next frame. 
        /// </summary>
        [DataMember]
        public Guid? MapElementId
        {
            get;
            set;
        }

        /// <summary>
        /// If this frame is the current frame, this property contains the developer name of the current map element.
        /// If this frame refers to one of the parent frames, this property contains the id of a Subflow map element that was the entry point to the next frame. 
        /// </summary>
        [DataMember]
        public string MapElementDeveloperName
        {
            get;
            set;
        }

        /// <summary>
        /// This is our reference running user.  By default, the running user is the person who initializes the flow.  From then on,
        /// the running user can be re-assigned as needed - but it is always a single user identity that is tagged as the running user.
        /// </summary>
        [DataMember]
        public string RunningUserId
        {
            get;
            set;
        }
        
        /// <summary>
        /// The state entry representing changes to the state that have been made since the last commit
        /// </summary>
        [DataMember]
        public StateEntryAPI PrecommitStateEntry
        {
            get;
            set;
        }
        
        /// <summary>
        /// The list of value elements that are associated with this frame
        /// </summary>
        [DataMember]
        public List<StateValueAPI> Values
        {
            get;
            set;
        }
    }
} 