using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Shared;

namespace ManyWho.Flow.SDK.Draw.Elements
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class InputValueAPI
    {
        [DataMember]
        public String id
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
        public String contentValue
        {
            get;
            set;
        }
    }
}