using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.Elements.Type;

namespace ManyWho.Flow.SDK.Run.Elements.UI
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageComponentDataResponseAPI
    {
        [DataMember]
        public String pageComponentId
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
        public Boolean isRequired
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
        public List<ObjectAPI> objectData
        {
            get;
            set;
        }

        [DataMember]
        public ObjectDataRequestAPI objectDataRequest
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
        public String content
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isValid
        {
            get;
            set;
        }

        [DataMember]
        public String validationMessage
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
