using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Shared;

namespace ManyWho.Flow.SDK.Run.Elements
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class InputValueRequestAPI
    {
        [DataMember]
        public SharedElementIdAPI SharedElementIdContentValueToReference
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
    }
}