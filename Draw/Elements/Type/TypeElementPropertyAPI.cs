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
    public class TypeElementPropertyAPI
    {
        /// <summary>
        /// The unique identifier for the type element property value. This property is created by the service.
        /// </summary>
        [DataMember]
        public string id
        {
            get;
            set;
        }

        /// <summary>
        /// The developer name for the type element property. This will be used to identify the property in API calls that use values of this Type.
        /// </summary>
        [DataMember]
        public string developerName
        {
            get;
            set;
        }

        /// <summary>
        /// The type of content the type element property holds.
        /// </summary>
        [DataMember]
        public string contentType
        {
            get;
            set;
        }

        [DataMember]
        public string contentFormat
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the Type held in this type element property. This property should only be assigned if this type element property is a ContentType of ContentObject or ContentList. The unique identifier should be for the object or list of objects that will be stored.
        /// </summary>
        [DataMember]
        public string typeElementId
        {
            get;
            set;
        }

        /// <summary>
        /// This property is used to specify the developer name rather than the identifier of the associated Type (see typeElementId). This property is only used as part of the Service install. Do not use this property if you are creating a Type through the API manually - you must use the typeElementId.
        /// </summary>
        [DataMember]
        public string typeElementDeveloperName
        {
            get;
            set;
        }
    }
}