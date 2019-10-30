using System;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Flow;

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
    }
} 