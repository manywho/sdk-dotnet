using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.Elements.Type;
using ManyWho.Flow.SDK.Draw.Elements.Shared;

namespace ManyWho.Flow.SDK.Run.Elements.Map
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class OutputValueResponseAPI
    {
        [DataMember]
        public SharedElementIdAPI SharedElementToApplyContentValue
        {
            get;
            set;
        }

        [DataMember]
        public String ContentValue
        {
            get;
            set;
        }

        [DataMember]
        public List<ObjectAPI> ObjectData
        {
            get;
            set;
        }
    }
}
