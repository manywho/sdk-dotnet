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

namespace ManyWho.Flow.SDK.Draw.Elements.Value
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ValueElementIdReferenceAPI : ValueElementIdAPI
    {
        /// <summary>
        /// The developer name from the Value.
        /// </summary>
        [DataMember]
        public String developerName
        {
            get;
            set;
        }

        /// <summary>
        /// The developer name of the Type associated with the Value. This will be a non-null value for Objects and Lists.
        /// </summary>
        [DataMember]
        public String typeElementDeveloperName
        {
            get;
            set;
        }

        /// <summary>
        /// The developer name of one of the properties available for the Type.
        /// </summary>
        [DataMember]
        public String typeElementPropertyDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public string typeElementEntryTypeElementDeveloperName
        {
            get;
            set;
        }
        
        /// <summary>
        /// The unique identifier for the Type property associated with the Value. This will be a non-null value for Objects and Lists for entries referring to a property.
        /// </summary>
        [DataMember]
        public String typeElementPropertyTypeElementId
        {
            get;
            set;
        }

        /// <summary>
        /// The element type from the Value.
        /// </summary>
        [DataMember]
        public String elementType
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the Type associated with the Value.
        /// </summary>
        [DataMember]
        public String typeElementId
        {
            get;
            set;
        }

        [DataMember]
        public String serviceElementId
        {
            get;
            set;
        }

        [DataMember]
        public String serviceElementDeveloperName
        {
            get;
            set;
        }

        /// <summary>
        /// The ContentType from the Value.
        /// </summary>
        [DataMember]
        public String contentType
        {
            get;
            set;
        }

        [DataMember]
        public String parentContentType
        {
            get;
            set;
        }

        /// <summary>
        /// The isFixed property from the Value.
        /// </summary>
        [DataMember]
        public Boolean isFixed
        {
            get;
            set;
        }

        [DataMember]
        public string access
        {
            get;
            set;
        }
    }
}
