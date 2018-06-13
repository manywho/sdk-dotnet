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

namespace ManyWho.Flow.SDK.Draw.Elements.Type
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class TypeElementPropertyBindingAPI
    {
        /// <summary>
        /// The name of the database field in the table that this binding should be applied. If no underlying table is used, this should represent a unique name that will allow the Service implementation to identify how to store the object property.
        /// </summary>
        [DataMember]
        public string databaseFieldName
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the type element property that this binding relates to.
        /// </summary>
        [DataMember]
        public string typeElementPropertyId
        {
            get;
            set;
        }

        /// <summary>
        /// The developer name for the type element property that this binding relates to. This property is only used in the Service installation and is not supported as part of a manual Type creation.
        /// </summary>
        [DataMember]
        public string typeElementPropertyDeveloperName
        {
            get;
            set;
        }

        /// <summary>
        /// The content type of the database field in the table that this binding should be applied. For example, the content type in ManyWho may be ContentNumber, but in the underlying database, the actual field type is Decimal. This is an optional property that depends on the Service implementation.
        /// </summary>
        [DataMember]
        public string databaseContentType
        {
            get;
            set;
        }
    }
}
