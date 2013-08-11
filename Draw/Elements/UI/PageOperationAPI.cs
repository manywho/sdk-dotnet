using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Elements.UI
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageOperationAPI
    {
        [DataMember]
        public String id
        {
            get;
            set;
        }

        /// <summary>
        /// This object will not e null if we want to perform an assignment to a form element.  This can be everything from changing
        /// the value to altering the meta-data of the field.  The only thing the assignment does not include is the application of
        /// a filter to the data inside the field.
        /// </summary>
        [DataMember]
        public PageOperationAssignmentAPI assignment
        {
            get;
            set;
        }

        /// <summary>
        /// This object will not be null if we want to apply a filter to a field.  We only support simple filtering with 1 where
        /// clause for the query.  This is to simplify the UI logic considerably for "in-UI" logic.  For more complex filters, the
        /// ObjectDataRequest propety should be used.
        /// </summary>
        [DataMember]
        public PageOperationFilterAPI filter
        {
            get;
            set;
        }
    }
}