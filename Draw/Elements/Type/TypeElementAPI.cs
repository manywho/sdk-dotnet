using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Elements.Type
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class TypeElementAPI : ElementAPI
    {
        [DataMember]
        public String id
        {
            get;
            set;
        }

        [DataMember]
        public String serviceElementId
        {
            get;
            set;
        }

        [DataMember]
        public Boolean selectable
        {
            get;
            set;
        }

        [DataMember]
        public Boolean updateable
        {
            get;
            set;
        }

        [DataMember]
        public Boolean deletable
        {
            get;
            set;
        }
    }
}