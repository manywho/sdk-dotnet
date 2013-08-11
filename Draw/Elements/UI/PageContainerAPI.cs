using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Elements.UI
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageContainerAPI
    {
        [DataMember]
        public String id
        {
            get;
            set;
        }

        [DataMember]
        public String containerType
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
        public String label
        {
            get;
            set;
        }

        [DataMember]
        public List<PageContainerAPI> pageContainers
        {
            get;
            set;
        }

        [DataMember]
        public Int32 order
        {
            get;
            set;
        }

        [DataMember]
        public List<PageTagAPI> tags
        {
            get;
            set;
        }
    }
}
