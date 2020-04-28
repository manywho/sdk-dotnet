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

namespace ManyWho.Flow.SDK.Draw.Elements.Type
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ListFilterMinimalConfigAPI
    {
        /// <summary>
        /// The comparison when evaluating the 'where' entries.  This is either "AND" or "OR" and we do not support nesting (just yet anyway).
        /// </summary>
        [DataMember]
        public string comparisonType
        {
            get;
            set;
        }

        /// <summary>
        /// The filter criteria that should be applied during the lookup.
        /// </summary>
        [DataMember]
        public List<ListFilterWhereConfigAPI> where
        {
            get;
            set;
        }

        /// <summary>
        /// A list of nested minimal ListFilters that can be used for grouped ordering and comparisons
        /// </summary>
        [DataMember]
        public List<ListFilterMinimalConfigAPI> listFilters
        {
            get;
            set;
        }
    }
}
