using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Elements.UI
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageElementRequestAPI : PageElementAPI
    {
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
        public List<PageComponentAPI> pageComponents
        {
            get;
            set;
        }

        [DataMember]
        public List<PageConditionAPI> pageConditions
        {
            get;
            set;
        }

        [DataMember]
        public Boolean stopConditionsOnFirstTrue
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

        [DataMember]
        public Boolean updateByName
        {
            get;
            set;
        }
    }
}
