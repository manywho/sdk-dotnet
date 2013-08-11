using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Elements.Group
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class GroupElementRequestAPI : GroupElementAPI
    {
        [DataMember]
        public Boolean updateByName
        {
            get;
            set;
        }
    }
}
