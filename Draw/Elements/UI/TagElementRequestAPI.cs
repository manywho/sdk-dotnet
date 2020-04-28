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

namespace ManyWho.Flow.SDK.Draw.Elements.UI
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class TagElementRequestAPI : ElementAPI
    {
        /// <summary>
        /// The type of Value the Tag holds. As part of the Page layout creation, the Tag will be associated with a Value. The Value bound to this Tag must be of the same content type.
        /// </summary>
        [DataMember]
        public string contentType
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the Type and object or list data must adhere to in structure (the Type basically defines the 'interface' that all objects and lists stored in this Value must implement). This property is only applicable for ContentObject and ContentList content types. As part of the Page layout creation, the Tag will be associated with a Value. The Value bound to this Tag must be of the same Type.
        /// </summary>
        [DataMember]
        public string typeElementId
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the platform should attempt to find a Tag with the same developer name as the one provided and match them up by name as opposed to 'id'. This is useful when creating scripts to create Flows - as you can use the developerName property as the reference as opposed to needing to know the ids of all created Elements.
        /// </summary>
        [DataMember]
        public bool updateByName
        {
            get;
            set;
        }
    }
}
