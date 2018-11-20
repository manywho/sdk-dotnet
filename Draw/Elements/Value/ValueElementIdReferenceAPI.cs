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
        public string developerName
        {
            get;
            set;
        }

        /// <summary>
        /// The developer name of the Type associated with the Value. This will be a non-null value for Objects and Lists.
        /// </summary>
        [DataMember]
        public string typeElementDeveloperName
        {
            get;
            set;
        }

        /// <summary>
        /// The developer name of one of the properties available for the Type.
        /// </summary>
        [DataMember]
        public string typeElementPropertyDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public string typeElementPropertyTypeElementDeveloperName
        {
            get;
            set;
        }
        
        /// <summary>
        /// The unique identifier for the Type property associated with the Value. This will be a non-null value for Objects and Lists for entries referring to a property.
        /// </summary>
        [DataMember]
        public string typeElementPropertyTypeElementId
        {
            get;
            set;
        }

        /// <summary>
        /// The element type from the Value.
        /// </summary>
        [DataMember]
        public string elementType
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the Type associated with the Value.
        /// </summary>
        [DataMember]
        public string typeElementId
        {
            get;
            set;
        }

        [DataMember]
        public string serviceElementId
        {
            get;
            set;
        }

        [DataMember]
        public string serviceElementDeveloperName
        {
            get;
            set;
        }

        /// <summary>
        /// The ContentType from the Value.
        /// </summary>
        [DataMember]
        public string contentType
        {
            get;
            set;
        }

        [DataMember]
        public string parentContentType
        {
            get;
            set;
        }

        /// <summary>
        /// The isFixed property from the Value.
        /// </summary>
        [DataMember]
        public bool isFixed
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
