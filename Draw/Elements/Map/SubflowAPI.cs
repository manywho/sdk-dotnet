using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Flow;

namespace ManyWho.Flow.SDK.Draw.Elements.Map
{
    public class SubflowAPI
    {
        public SubflowAPI()
        {
        }

        public SubflowAPI(FlowIdAPI flowId)
        {
            this.flowId = flowId;
        }

        /// <summary>
        /// The identifier of the flow that is called as subflow
        /// </summary>
        [DataMember]
        public FlowIdAPI flowId
        {
            get;
            set;
        }

        /// <summary>
        /// The list of arguments passed in a subflow call
        /// </summary>
        [DataMember]
        public List<SubflowArgumentAPI> arguments
        {
            get;
            set;
        } = new List<SubflowArgumentAPI>();

        /// <summary>
        /// Indicates if on jumping specified by the selectedMapElementPath property (so called "long jump"), the Engine should restore value elements from the archived frame
        /// when invoking this Subflow map element for the second (or more) time
        /// </summary>
        [DataMember]
        public bool? restoreValuesOnJump
        {
            get; 
            set;
        }
    }
}