using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Elements.Type
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class TypeElementResponseAPI : TypeElementRequestAPI
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
    }
}