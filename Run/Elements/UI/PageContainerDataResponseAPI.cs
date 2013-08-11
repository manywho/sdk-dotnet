using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.Elements.Type;

namespace ManyWho.Flow.SDK.Run.Elements.UI
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageContainerDataResponseAPI
    {
        [DataMember]
        public String pageContainerId
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isEnabled
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isEditable
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isVisible
        {
            get;
            set;
        }

        [DataMember]
        public List<EngineValueAPI> tags
        {
            get;
            set;
        }
    }
}
