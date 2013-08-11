using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run.Elements.Type
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ObjectAPI
    {
        [DataMember]
        public String internalId
        {
            get;
            set;
        }

        [DataMember]
        public String externalId
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
        public List<PropertyAPI> properties
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isSelected
        {
            get;
            set;
        }
    }
}
