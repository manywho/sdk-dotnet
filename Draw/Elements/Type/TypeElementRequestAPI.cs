using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.UI;

namespace ManyWho.Flow.SDK.Draw.Elements.Type
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class TypeElementRequestAPI : TypeElementAPI
    {
        [DataMember]
        public List<TypeElementEntryAPI> typeElementEntries
        {
            get;
            set;
        }

        [DataMember]
        public List<TypeElementBindingAPI> bindings
        {
            get;
            set;
        }

        [DataMember]
        public Boolean updateByName
        {
            get;
            set;
        }
    }
}
