using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.Elements.Type;

namespace ManyWho.Flow.SDK.Run.Elements.UI
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageComponentInputResponseRequestAPI
    {
        [DataMember]
        public String pageComponentId
        {
            get;
            set;
        }

        [DataMember]
        public String contentValue
        {
            get;
            set;
        }

        [DataMember]
        public List<ObjectAPI> objectData
        {
            get;
            set;
        }
    }
}