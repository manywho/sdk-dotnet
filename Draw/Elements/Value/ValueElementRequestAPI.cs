using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.Elements.Type;
using ManyWho.Flow.SDK.Draw.Elements.Map;

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
    public class ValueElementRequestAPI : ValueElementAPI
    {
        /// <summary>
        /// Indicates if the value of the Value can be changed by operations in the Flow or from outside systems. If this property is set to 'true', the Value will act like a 'constant' - i.e. it can't be changed by anyone except the Flow author at design time.
        /// </summary>
        [DataMember]
        public Boolean isFixed
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isVersionless
        {
            get;
            set;
        }

        /// <summary>
        /// Sets the level of access this Value has to change. In many situations, Values can only be changed by the operations defined in your Flow and the value is not exposed outside of the Flow. Alternatively, you may wish to allow the value of the Value to be assigned at initialization.
        /// </summary>
        [DataMember]
        public String access
        {
            get;
            set;
        }

        /// <summary>
        /// The type of content the Value holds.
        /// </summary>
        [DataMember]
        public String contentType
        {
            get;
            set;
        }

        [DataMember]
        public String contentFormat
        {
            get;
            set;
        }

        /// <summary>
        /// The default content value for the Value before any operations have been performed. This is for primitive Values.
        /// </summary>
        [DataMember]
        public String defaultContentValue
        {
            get;
            set;
        }

        /// <summary>
        /// The default object data for the Value before any operations have been performed. This is for Object and List Values.
        /// </summary>
        [DataMember]
        public List<ObjectAPI> defaultObjectData
        {
            get;
            set;
        }

        /// <summary>
        /// The operations that should be performed when the object is initialized. Initialization operations are only appropriate for Values of content type ContentObject.
        /// </summary>
        [DataMember]
        public List<OperationAPI> initializationOperations
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the Type and object or list data must adhere to in structure (the Type basically defines the 'interface' that all objects and lists stored in this Value must implement). This property is only applicable for ContentObject and ContentList content types.
        /// </summary>
        [DataMember]
        public String typeElementId
        {
            get;
            set;
        }

        [DataMember]
        public String typeElementDeveloperName
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the platform should attempt to find a Value with the same developer name as the one provided and match them up by name as opposed to 'id'. This is useful when creating scripts to create Flows - as you can use the developerName property as the reference as opposed to needing to know the ids of all created Elements.
        /// </summary>
        [DataMember]
        public Boolean updateByName
        {
            get;
            set;
        }
    }
}