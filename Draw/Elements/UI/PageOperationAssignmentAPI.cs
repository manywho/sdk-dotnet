using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Elements.UI
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageOperationAssignmentAPI
    {
        /// <summary>
        /// The form element to have the assignment applied.
        /// </summary>
        [DataMember]
        public PageObjectReferenceAPI assignee
        {
            get;
            set;
        }

        /// <summary>
        /// The type of assignment being performed.
        /// </summary>
        [DataMember]
        public String assignment
        {
            get;
            set;
        }

        /// <summary>
        /// The form element of value to use in the assignment.
        /// </summary>
        [DataMember]
        public PageObjectReferenceAPI assignor
        {
            get;
            set;
        }
    }
}
