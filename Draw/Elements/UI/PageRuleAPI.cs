using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Elements.UI
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageRuleAPI
    {
        [DataMember]
        public String id
        {
            get;
            set;
        }

        [DataMember]
        public PageObjectReferenceAPI leftPageObjectReference
        {
            get;
            set;
        }

        [DataMember]
        public String criteria
        {
            get;
            set;
        }

        [DataMember]
        public PageObjectReferenceAPI rightPageObjectReference
        {
            get;
            set;
        }
    }
}
