using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Flow
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class FlowGraphResponseAPI : FlowGraphRequestAPI
    {
        [DataMember]
        public String tenantId
        {
            get;
            set;
        }
    }
}