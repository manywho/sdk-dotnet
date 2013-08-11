using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Util;

namespace ManyWho.Flow.SDK.Draw.Content
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class CommandAPI
    {
        [DataMember]
        public String id
        {
            get;
            set;
        }

        [DataMember]
        public String commandType
        {
            get;
            set;
        }

        [DataMember]
        public Dictionary<String, String> properties
        {
            get;
            set;
        }
    }
}