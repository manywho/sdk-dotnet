using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run.Elements.Type
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ObjectDataTypePropertyAPI
    {
        [DataMember]
        public String developerName
        {
            get;
            set;
        }

        [DataMember]
        public List<ObjectDataTypeAPI> List
        {
            get;
            set;
        }
    }
}
