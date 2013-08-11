using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Elements.Type
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class TypeElementIdAPI
    {
        [DataMember]
        public Guid id
        {
            get;
            set;
        }

        [DataMember]
        public Guid versionId
        {
            get;
            set;
        }
    }
}