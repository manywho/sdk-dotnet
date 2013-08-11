using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run.Elements.UI
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageResponseAPI
    {
        [DataMember]
        public String label
        {
            get;
            set;
        }

        [DataMember]
        public List<PageContainerResponseAPI> pageContainerResponses
        {
            get;
            set;
        }

        [DataMember]
        public List<PageComponentResponseAPI> pageComponentResponses
        {
            get;
            set;
        }

        [DataMember]
        public List<PageComponentDataResponseAPI> pageComponentDataResponses
        {
            get;
            set;
        }

        [DataMember]
        public List<PageContainerDataResponseAPI> pageContainerDataResponses
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
    }
}