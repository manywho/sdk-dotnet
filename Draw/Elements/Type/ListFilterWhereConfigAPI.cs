using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Shared;

namespace ManyWho.Flow.SDK.Draw.Elements.Type
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ListFilterWhereConfigAPI
    {
        /// <summary>
        /// The column to filter by.
        /// </summary>
        [DataMember]
        public String columnTypeElementEntryId
        {
            get;
            set;
        }

        /// <summary>
        /// The criteria of the filter.
        /// </summary>
        [DataMember]
        public String criteria
        {
            get;
            set;
        }

        /// <summary>
        /// The value to filter by.
        /// </summary>
        [DataMember]
        public SharedElementIdAPI sharedElementValueToReference
        {
            get;
            set;
        }
    }
}
