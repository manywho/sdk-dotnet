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
    public class OperationAPI
    {
        [DataMember]
        public String id
        {
            get;
            set;
        }

        [DataMember]
        public SharedElementIdAPI sharedElementToApplyContentValue
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
        public String typeElementId
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
