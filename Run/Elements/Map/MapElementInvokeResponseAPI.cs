using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.Elements.UI;

namespace ManyWho.Flow.SDK.Run.Elements.Map
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class MapElementInvokeResponseAPI
    {
        [DataMember]
        public String mapElementId
        {
            get;
            set;
        }

        [DataMember]
        public String developerName
        {
            get;
            set;
        }

        [DataMember]
        public PageResponseAPI pageResponse
        {
            get;
            set;
        }

        [DataMember]
        public List<OutcomeResponseAPI> outcomeResponses
        {
            get;
            set;
        }

        [DataMember]
        public Dictionary<String, String> rootFaults
        {
            get;
            set;
        }
    }
}
