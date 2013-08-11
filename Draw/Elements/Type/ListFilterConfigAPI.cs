using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Shared;

namespace ManyWho.Flow.SDK.Draw.Elements.Type
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ListFilterConfigAPI
    {
        /// <summary>
        /// The identifier of the actual object to filter by - this basically gives an individual result back.
        /// </summary>
        [DataMember]
        public SharedElementIdAPI filterId
        {
            get;
            set;
        }

        /// <summary>
        /// The comparison when evaluating the 'where' entries.  This is either "AND" or "OR" and we do not support nesting (just yet anyway).
        /// </summary>
        public String comparisonType
        {
            get;
            set;
        }

        /// <summary>
        /// The where filter to apply to the list.
        /// </summary>
        [DataMember]
        public List<ListFilterWhereConfigAPI> where
        {
            get;
            set;
        }

        /// <summary>
        /// The type element entry id of the column to order by.
        /// </summary>
        [DataMember]
        public String orderByTypeElementEntryId
        {
            get;
            set;
        }

        /// <summary>
        /// The direction of the ordering.
        /// </summary>
        [DataMember]
        public String orderByDirection
        {
            get;
            set;
        }

        /// <summary>
        /// The number of objects to retrieve in the list.
        /// </summary>
        [DataMember]
        public Int32 limit
        {
            get;
            set;
        }
    }
}
