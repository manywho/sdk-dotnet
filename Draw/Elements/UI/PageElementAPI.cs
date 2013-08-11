using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Elements.UI
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageElementAPI : ElementAPI
    {
        [DataMember]
        public String id
        {
            get;
            set;
        }
    }
}