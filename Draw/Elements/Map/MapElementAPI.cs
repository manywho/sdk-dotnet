using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Elements.Map
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class MapElementAPI : ElementAPI
    {
        [DataMember]
        public String id
        {
            get;
            set;
        }

        [DataMember]
        public String groupElementId
        {
            get;
            set;
        }

        [DataMember]
        public Int32 x
        {
            get;
            set;
        }

        [DataMember]
        public Int32 y
        {
            get;
            set;
        }

        [DataMember]
        public List<OutcomeAPI> outcomes
        {
            get;
            set;
        }
    }
}