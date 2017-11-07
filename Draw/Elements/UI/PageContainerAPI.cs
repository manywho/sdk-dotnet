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

namespace ManyWho.Flow.SDK.Draw.Elements.UI
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageContainerAPI
    {
        /// <summary>
        /// The unique identifier for the page container. This property is created by the service.
        /// </summary>
        [DataMember]
        public String id
        {
            get;
            set;
        }

        /// <summary>
        /// The type of container to render. The current player implementations support the container types listed in the enumeration. However, developers can define their own container types (but will need to make sure these are then supported in the player).
        /// </summary>
        [DataMember]
        public String containerType
        {
            get;
            set;
        }

        /// <summary>
        /// The developer name for the page container. This will be used to identify the container in your layout - and this can be used to ease the creation of the page metadata. Developers should ensure that the developer name is unique for the page.
        /// </summary>
        [DataMember]
        public String developerName
        {
            get;
            set;
        }

        /// <summary>
        /// The label for this particular container.
        /// </summary>
        [DataMember]
        public String label
        {
            get;
            set;
        }

        /// <summary>
        /// The tree hierarchy of page containers that are children of this page container. Conceptually, page containers are similar to HTML 'div' tags.
        /// </summary>
        [DataMember]
        public List<PageContainerAPI> pageContainers
        {
            get;
            set;
        }

        /// <summary>
        /// The order in which the page container should be rendered relative to its peers. The lowest number is rendered first.
        /// </summary>
        [DataMember]
        public Int32 order
        {
            get;
            set;
        }

        /// <summary>
        /// Arbitrary key value pairs that may help the container render/execute. Use attributes to extend our PageContainer metadata with implementation specific settings.
        /// </summary>
        [DataMember]
        public Dictionary<String, String> attributes
        {
            get;
            set;
        }

        /// <summary>
        /// The list of page tags that allow additional metadata to be applied to the page container. Conceptually tags can be used to mimic html css but can also be used to provided data to enrich functionality of the page container.
        /// </summary>
        [DataMember]
        public List<PageTagAPI> tags
        {
            get;
            set;
        }
    }
}
