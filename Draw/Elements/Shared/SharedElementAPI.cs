using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Elements.Shared
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class SharedElementAPI : ElementAPI
    {
        [DataMember]
        public String id
        {
            get;
            set;
        }

        [DataMember]
        public String groupType
        {
            get;
            set;
        }

        [DataMember]
        public String userType
        {
            get;
            set;
        }
    }
}