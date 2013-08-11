using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run.Elements.Type
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ListFilterWhereAPI
    {
        [DataMember]
        public String columnName
        {
            get;
            set;
        }

        [DataMember]
        public String criteria
        {
            get;
            set;
        }

        [DataMember]
        public String value
        {
            get;
            set;
        }
    }
}
