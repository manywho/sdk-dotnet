using System;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run.State
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class StackFrameInfoAPI
    {
        [DataMember]
        public Guid FlowId { get; set; }
        
        [DataMember]
        public Guid? MapElementId { get; set; }
    }
}