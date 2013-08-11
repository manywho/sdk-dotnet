using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run.Elements.Type
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ListFilterAPI
    {
        /// <summary>
        /// The identifier of the actual object to filter by - this basically gives an individual result back.
        /// </summary>
        [DataMember]
        public String id
        {
            get;
            set;
        }

        /// <summary>
        /// The comparison type to use when evaluating the wheres.
        /// </summary>
        [DataMember]
        public String comparisonType
        {
            get;
            set;
        }

        /// <summary>
        /// The where filter to apply to the list.
        /// </summary>
        [DataMember]
        public List<ListFilterWhereAPI> where
        {
            get;
            set;
        }

        /// <summary>
        /// The developer name of the column to order by.
        /// </summary>
        [DataMember]
        public String orderByPropertyDeveloperName
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
