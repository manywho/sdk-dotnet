using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    [Serializable]
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ListFilterWhereConfigAPI
    {
        /// <summary>
        /// The column to filter by.
        /// </summary>
        [DataMember]
        public String columnTypeElementPropertyId
        {
            get;
            set;
        }

        /// <summary>
        /// The criteria of the filter.
        /// </summary>
        [DataMember]
        public String criteriaType
        {
            get;
            set;
        }

        /// <summary>
        /// The value to filter by.
        /// </summary>
        [DataMember]
        public ValueElementIdAPI valueElementToReferenceId
        {
            get;
            set;
        }
    }
}
