using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Flow
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class FlowIdAPI
    {
        [DataMember]
        public String id
        {
            get;
            set;
        }

        [DataMember]
        public String versionId
        {
            get;
            set;
        }
    }
}