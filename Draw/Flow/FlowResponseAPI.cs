using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Map;

namespace ManyWho.Flow.SDK.Draw.Flow
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class FlowResponseAPI : FlowRequestAPI
    {
        [DataMember]
        public DateTime dateCreated
        {
            get;
            set;
        }

        [DataMember]
        public DateTime dateModified
        {
            get;
            set;
        }

        [DataMember]
        public String userCreated
        {
            get;
            set;
        }

        [DataMember]
        public String userModified
        {
            get;
            set;
        }

        [DataMember]
        public String userOwner
        {
            get;
            set;
        }

        [DataMember]
        public String alertEmail
        {
            get;
            set;
        }
    }
}