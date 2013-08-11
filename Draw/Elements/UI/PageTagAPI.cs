using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Shared;

namespace ManyWho.Flow.SDK.Draw.Elements.UI
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageTagAPI
    {
        [DataMember]
        public SharedElementIdAPI sharedElementContentValueToReference
        {
            get;
            set;
        }

        [DataMember]
        public String tagElementId
        {
            get;
            set;
        }
    }
}
