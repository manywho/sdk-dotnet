using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Content;
using ManyWho.Flow.SDK.Draw.Elements.Shared;

namespace ManyWho.Flow.SDK.Draw.Elements.Map
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class RuleAPI
    {
        [DataMember]
        public String id
        {
            get;
            set;
        }

        [DataMember]
        public SharedElementIdAPI leftSharedElementContentValueToReference
        {
            get;
            set;
        }

        [DataMember]
        public String criteriaType
        {
            get;
            set;
        }

        [DataMember]
        public SharedElementIdAPI rightSharedElementContentValueToReference
        {
            get;
            set;
        }
    }
}