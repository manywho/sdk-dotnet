using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run.Elements.UI
{
    /// <summary>
    /// This acts as the column descriptor for rendering the table content stored in the content property (as part of the parent
    /// field definition).
    /// </summary>
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageComponentColumnResponseAPI
    {
        /// <summary>
        /// This is the developer name of the type element entry.
        /// </summary>
        [DataMember]
        public String developerName
        {
            get;
            set;
        }

        [DataMember]
        public String typeElementEntryId
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
        public Boolean isDisplayValue
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
