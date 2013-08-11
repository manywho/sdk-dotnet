using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run.Elements.UI
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageRequestAPI
    {
        [DataMember]
        public List<PageComponentInputResponseRequestAPI> pageComponentInputResponses
        {
            get;
            set;
        }
    }
}