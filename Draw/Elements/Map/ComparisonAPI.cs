using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Elements.Map
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ComparisonAPI
    {
        [DataMember]
        public String id
        {
            get;
            set;
        }

        [DataMember]
        public String comparisonType
        {
            get;
            set;
        }

        [DataMember]
        public List<RuleAPI> rules
        {
            get;
            set;
        }

        [DataMember]
        public List<ComparisonAPI> comparisons
        {
            get;
            set;
        }

        [DataMember]
        public Int32 order
        {
            get;
            set;
        }
    }
}