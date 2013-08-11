using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
