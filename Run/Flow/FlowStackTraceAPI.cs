using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.Flow;

namespace ManyWho.Flow.SDK.Run.State
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class FlowStackTraceAPI
    {
        [DataMember]
        public List<FlowStackFrameAPI> frames
        {
            get; 
            set;
        }
    }
}