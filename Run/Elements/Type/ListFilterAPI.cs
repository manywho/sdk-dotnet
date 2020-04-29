using System.Collections.Generic;
using System.Runtime.Serialization;

/*!

Copyright 2013 Manywho, Inc.

Licensed under the Manywho License, Version 1.0 (the "License"); you may not use this
file except in compliance with the License.

You may obtain a copy of the License at: http://manywho.com/sharedsource

Unless required by applicable law or agreed to in writing, software distributed under
the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the specific language governing
permissions and limitations under the License.

*/

namespace ManyWho.Flow.SDK.Run.Elements.Type
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ListFilterAPI : ListFilterMinimalAPI
    {
        /// <summary>
        /// The identifier of the actual object to filter by - this basically gives an individual result back.
        /// </summary>
        [DataMember]
        public string id
        {
            get;
            set;
        }

        /// <summary>
        /// Use the list of provided objects as the filter for the lookup.  This allows us to refresh data that can be transient in the remote system.
        /// </summary>
        [DataMember]
        public bool filterByProvidedObjects
        {
            get;
            set;
        }

        /// <summary>
        /// The developer name of the column to order by.
        /// </summary>
        [DataMember]
        public string orderByPropertyDeveloperName
        {
            get;
            set;
        }

        /// <summary>
        /// The direction of the ordering.
        /// </summary>
        [DataMember]
        public string orderByDirectionType
        {
            get;
            set;
        }

        [DataMember]
        public List<ListFilterOrderByAPI> orderBy
        {
            get;
            set;
        } = new List<ListFilterOrderByAPI>();

        /// <summary>
        /// The number of objects to retrieve in the list.
        /// </summary>
        [DataMember]
        public int limit
        {
            get;
            set;
        }

        /// <summary>
        /// The number of records to skip past to effectively support paging of the data.
        /// </summary>
        [DataMember]
        public int offset
        {
            get;
            set;
        }

        /// <summary>
        /// An optional offset token, used for pagination by the service if required
        /// </summary>
        [DataMember]
        public string offsetToken
        {
            get;
            set;
        }

        /// <summary>
        /// The search string that should be used in addition to any filter criteria.
        /// </summary>
        [DataMember]
        public string search
        {
            get;
            set;
        }

        /// <summary>
        /// Any extra criteria that should be used when searching
        /// </summary>
        [DataMember]
        public List<ListFilterSearchCriteriaAPI> searchCriteria
        {
            get;
            set;
        } = new List<ListFilterSearchCriteriaAPI>();
    }
}
