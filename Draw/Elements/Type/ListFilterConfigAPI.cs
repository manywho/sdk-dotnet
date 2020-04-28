using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Value;

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

namespace ManyWho.Flow.SDK.Draw.Elements.Type
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ListFilterConfigAPI : ListFilterMinimalConfigAPI
    {
        /// <summary>
        /// The reference to the Value that holds a very specific identifier to filter the objects by. This property should be used when loading specific objects as opposed to lists of object results.
        /// </summary>
        [DataMember]
        public ValueElementIdAPI filterId
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the property in the Type (associated with this filter) that should be used for ordering the results.
        /// </summary>
        [DataMember]
        public string orderByTypeElementPropertyId
        {
            get;
            set;
        }

        /// <summary>
        /// The direction in which to order the results.
        /// </summary>
        [DataMember]
        public string orderByDirectionType
        {
            get;
            set;
        }

        /// <summary>
        /// The ordering clauses for the result set
        /// </summary>
        [DataMember]
        public List<ListFilterOrderByConfigAPI> orderBy
        {
            get;
            set;
        }

        /// <summary>
        /// The maximum number of results to return from the request.
        /// </summary>
        [DataMember]
        public int limit
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

        [DataMember]
        public List<ListFilterSearchCriteriaConfigAPI> searchCriteria
        {
            get;
            set;
        }

        /// <summary>
        /// A list of properties to select. Useful when it's not desirable to load the entire object, for performance
        /// and efficiency.
        /// </summary>
        [DataMember]
        public List<ListFilterPropertyConfigAPI> properties
        {
            get;
            set;
        }
    }
}
