using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Shared;

namespace ManyWho.Flow.SDK.Draw.Elements.Group
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class GroupAuthorizationLocationAPI
    {
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

        [DataMember]
        public SharedElementIdAPI sharedElementContentValueToReference
        {
            get;
            set;
        }

        [DataMember]
        public String attribute
        {
            get;
            set;
        }
    }
}
