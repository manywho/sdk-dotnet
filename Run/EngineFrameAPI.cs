using System;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class EngineFrameAPI
    {
        /// <summary>
        /// The id of the flow associated with this stack frame
        /// </summary>
        [DataMember]
        public Guid FlowId
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
    }
}