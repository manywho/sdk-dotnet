using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.Elements.Type;

namespace ManyWho.Flow.SDK.Run.Elements.UI
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageComponentResponseAPI
    {
        [DataMember]
        public String pageContainerDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public String pageContainerId
        {
            get;
            set;
        }

        [DataMember]
        public String id
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
        public String componentType
        {
            get;
            set;
        }

        [DataMember]
        public String contentType
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
        public List<PageComponentColumnResponseAPI> columns
        {
            get;
            set;
        }

        [DataMember]
        public Int32 size
        {
            get;
            set;
        }

        [DataMember]
        public Int32 maxSize
        {
            get;
            set;
        }

        [DataMember]
        public Int32 height
        {
            get;
            set;
        }

        [DataMember]
        public Int32 width
        {
            get;
            set;
        }

        [DataMember]
        public String hintValue
        {
            get;
            set;
        }

        [DataMember]
        public String helpInfo
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
        public Boolean isMultiSelect
        {
            get;
            set;
        }

        [DataMember]
        public Boolean hasEvents
        {
            get;
            set;
        }
    }
}