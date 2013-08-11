using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Type;

namespace ManyWho.Flow.SDK.Draw.Elements.Config
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ServiceInstallRequestAPI
    {
        [DataMember]
        public String id
        {
            get;
            set;
        }

        [DataMember]
        public List<TypeElementRequestAPI> types
        {
            get;
            set;
        }
    }
}
