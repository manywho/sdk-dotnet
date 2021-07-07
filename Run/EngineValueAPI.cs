using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.Elements.Type;

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

namespace ManyWho.Flow.SDK.Run
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class EngineValueAPI
    {
        /// <summary>
        /// The unique identifier for the value in the flow being assigned. Using the id to reference the value ensures that your player is guaranteed to be assigning the correct value. If you reference a value by developerName, it is possible for the author to break integration points simply by changing the name of the value. You must provide an 'id' or a 'developerName'.
        /// </summary>
        [DataMember]
        public string valueElementId
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the object type of the value in the flow being assigned. Using the typeElementId ensures that your player is guaranteed to be referencing the correct object type. If you use the typeElementDeveloperName property, a change in the type name can break the integration. We ask that you specify the type as we may in future support type casting and we therefore want to know the type you're passing in so we can validate it is correct before mapping to the super type.
        /// </summary>
        [DataMember]
        public string typeElementId
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the object property of the value in the flow being assigned. Typed objects all have properties. Using the typeElementPropertyId allows you to assign a property in an object value as opposed to the whole value. As with the other identifier references, using the typeElementPropertyId ensures that your player is guaranteed to be assigning the correct value. Using the typeElementPropertyDeveloperName makes it possible to break the integration if the author changes the developerName of a property in the type.
        /// </summary>
        [DataMember]
        public string typeElementPropertyId
        {
            get;
            set;
        }

        [DataMember]
        public string developerName
        {
            get;
            set;
        }

        /// <summary>
        /// The developer name for the object type of the value in the flow being assigned.
        /// </summary>
        [DataMember]
        public string typeElementDeveloperName
        {
            get;
            set;
        }

        /// <summary>
        /// The developer name for the object property of the value in the flow being assigned.
        /// </summary>
        [DataMember]
        public string typeElementPropertyDeveloperName
        {
            get;
            set;
        }

        /// <summary>
        /// The actual content value being assigned to the value in the flow. This property should be used for all "primitive", non-typed values in your flow. For example, if you are referencing a value called "First Name", this would be the value you actually want to assign to it: e.g. "Steve".
        /// </summary>
        [DataMember]
        public string contentValue
        {
            get;
            set;
        }

        /// <summary>
        /// The content type of the value you are passing into the flow. The content types are specified by the ContentType enumeration.
        /// </summary>
        [DataMember]
        public string contentType
        {
            get;
            set;
        }

        [DataMember]
        public List<ObjectAPI> objectData
        {
            get;
            set;
        }

        /// <summary>
        /// The access type of the value
        /// </summary>
        [DataMember]
        public string access
        {
            get;
            set;
        }
    }
}
