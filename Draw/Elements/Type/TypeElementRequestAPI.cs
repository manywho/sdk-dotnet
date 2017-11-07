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
    public class TypeElementRequestAPI : TypeElementAPI
    {
        [DataMember]
        public String serviceElementDeveloperName
        {
            get;
            set;
        }

        /// <summary>
        /// The list of properties for this Type. A property is very similar to a field in a table - it represents the structure of the data that will be stored in Values that use this Type.
        /// </summary>
        [DataMember]
        public List<TypeElementPropertyAPI> properties
        {
            get;
            set;
        }

        /// <summary>
        /// The list of bindings for the Type. A binding holds the mapping of properties to tables and fields in an underlying Service. A binding is not required for a Type if there is no plan to save the data in an external data store. When creating a binding, you will need to have saved the initial Type first so you have the identifiers for the various properties in the Type that need to be bound.
        /// </summary>
        [DataMember]
        public List<TypeElementBindingAPI> bindings
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the platform should attempt to find a Type with the same developer name as the one provided and match them up by name as opposed to 'id'. This is useful when creating scripts to create Flows - as you can use the developerName property as the reference as opposed to needing to know the ids of all created Elements.
        /// </summary>
        [DataMember]
        public Boolean updateByName
        {
            get;
            set;
        }
    }
}
