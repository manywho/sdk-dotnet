using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Elements.Type
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class TypeElementBindingAPI
    {
        [DataMember]
        public String id
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
        public String tableName
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
        public List<TypeElementFieldBindingAPI> fieldBindings
        {
            get;
            set;
        }
    }
}
