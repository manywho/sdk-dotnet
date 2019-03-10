using System;
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
    public class TypeElementBindingAPI
    {
        /// <summary>
        /// The unique identifier for the type element binding.
        /// </summary>
        [DataMember]
        public string id
        {
            get;
            set;
        }

        /// <summary>
        /// The developer name for the type element binding.
        /// </summary>
        [DataMember]
        public string developerName
        {
            get;
            set;
        }

        /// <summary>
        /// The developer summary the author provided to give more information about the type element binding.
        /// </summary>
        [DataMember]
        public string developerSummary
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the database table that this binding should be applied. If no underlying table is used or the binding involves multiple backend tables, this should represent a unique name that will allow the Service implementation to identify how to store the object.
        /// </summary>
        [DataMember]
        public string databaseTableName
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the Service that implements the mapping code to save objects and lists of this Type back to the data store.
        /// </summary>
        [DataMember]
        public string serviceElementId
        {
            get;
            set;
        }

        /// <summary>
        /// The list of type element property bindings. These are the individual mappings of type element properties to fields in the underlying data store implemented by the Service.
        /// </summary>
        [DataMember]
        public List<TypeElementPropertyBindingAPI> propertyBindings
        {
            get;
            set;
        }

        [DataMember]
        public Guid typeElementId
        {
            get;
            set;
        }
    }
}
