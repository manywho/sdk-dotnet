using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Util;

namespace ManyWho.Flow.SDK.Draw.Elements
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ElementAPI
    {
        [DataMember]
        public String elementType
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
        public String developerSummary
        {
            get;
            set;
        }
    }
}