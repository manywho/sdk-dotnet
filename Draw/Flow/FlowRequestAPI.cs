using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ManyWho.Flow.SDK.Draw.Content;
using ManyWho.Flow.SDK.Draw.Elements.Map;
using ManyWho.Flow.SDK.Draw.Elements.Type;
using ManyWho.Flow.SDK.Draw.Elements.Group;
using ManyWho.Flow.SDK.Draw.Elements.Shared;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Flow
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class FlowRequestAPI
    {
        [DataMember]
        public String editingToken
        {
            get;
            set;
        }

        [DataMember]
        public FlowIdAPI id
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

        [DataMember]
        public Boolean isActive
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isDefault
        {
            get;
            set;
        }

        [DataMember]
        public String startMapElementId
        {
            get;
            set;
        }

        [DataMember]
        public GroupAuthorizationAPI authorization
        {
            get;
            set;
        }
    }
}