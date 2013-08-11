using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Flow;
using ManyWho.Flow.SDK.Run.Elements;
using ManyWho.Flow.SDK.Run.Elements.Config;

namespace ManyWho.Flow.SDK.Run
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class EngineInitializationRequestAPI
    {
        [DataMember]
        public FlowIdAPI flowId
        {
            get;
            set;
        }

        [DataMember]
        public Dictionary<String, String> annotations
        {
            get;
            set;
        }

        [DataMember]
        public List<EngineValueAPI> inputs
        {
            get;
            set;
        }

        [DataMember]
        public String playerUrl
        {
            get;
            set;
        }

        [DataMember]
        public String joinPlayerUrl
        {
            get;
            set;
        }

        [DataMember]
        public String mode
        {
            get;
            set;
        }
    }
}
