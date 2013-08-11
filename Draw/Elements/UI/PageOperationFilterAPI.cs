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
    public class PageOperationFilterAPI
    {
        /// <summary>
        /// This is the reference field to apply the filter information contained in this action.
        /// </summary>
        [DataMember]
        public String fieldId
        {
            get;
            set;
        }

        /// <summary>
        /// A temporary reference to the field on which to apply this filter configuration.
        /// </summary>
        [DataMember]
        public String tempFieldReference
        {
            get;
            set;
        }

        /// <summary>
        /// This is the type element entry for the column field to do the filtering on.
        /// </summary>
        [DataMember]
        public String columnTypeElementEntryId
        {
            get;
            set;
        }

        /// <summary>
        /// The criteria for the filter to apply to the column.
        /// </summary>
        [DataMember]
        public String criteria
        {
            get;
            set;
        }

        /// <summary>
        /// The value to reference when performing the filter.
        /// </summary>
        [DataMember]
        public PageObjectReferenceAPI fieldValue
        {
            get;
            set;
        }

        /// <summary>
        /// This object will not be null if we want to apply a different object data request to the field in question.  This allows us
        /// to do more complex data querying than that provided by the "in-UI" Filter object above.  You cannot use the filter above
        /// with the object data request - it's basically either or.
        /// </summary>
        [DataMember]
        public ObjectDataRequestConfigAPI objectDataRequest
        {
            get;
            set;
        }
    }
}