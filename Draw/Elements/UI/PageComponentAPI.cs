using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Type;
using ManyWho.Flow.SDK.Draw.Elements.Shared;

namespace ManyWho.Flow.SDK.Draw.Elements.UI
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageComponentAPI
    {
        [DataMember]
        public String id
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
        public SharedElementIdAPI dataSharedElement
        {
            get;
            set;
        }

        /// <summary>
        /// Used to get the data in real-time from the external data source - using this object data request as the configuration of that
        /// request.
        /// </summary>
        [DataMember]
        public ObjectDataRequestConfigAPI objectDataRequest
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
        public String pageContainerDeveloperName
        {
            get;
            set;
        }

        /// <summary>
        /// We have a developer name field solely for external services - so they can match fields appropriately with respect
        /// to form layouts for types.
        /// </summary>
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
        public String content
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
        public List<PageComponentColumnAPI> columns
        {
            get;
            set;
        }

        [DataMember]
        public SharedElementIdAPI valueBindingSharedElement
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
        public Boolean required
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
        public List<PageTagAPI> tags
        {
            get;
            set;
        }
    }
}
