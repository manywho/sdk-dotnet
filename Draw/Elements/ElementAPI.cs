using System;
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

namespace ManyWho.Flow.SDK.Draw.Elements
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ElementAPI
    {
        /// <summary>
        /// The unique identifier for the element. The id should be null for "insert" requests and a valid identifier for "update" requests.
        /// </summary>
        [DataMember]
        public string id
        {
            get;
            set;
        }

        /// <summary>
        /// The type of element this metadata represents.
        /// </summary>
        [DataMember]
        public string elementType
        {
            get;
            set;
        }

        /// <summary>
        /// The developer name for the element. This is useful for keeping track of the element in the modelling tool and the API.
        /// </summary>
        [DataMember]
        public string developerName
        {
            get;
            set;
        }

        /// <summary>
        /// The developer summary the author provided to give more information about the element
        /// </summary>
        [DataMember]
        public string developerSummary
        {
            get;
            set;
        }
    }
}