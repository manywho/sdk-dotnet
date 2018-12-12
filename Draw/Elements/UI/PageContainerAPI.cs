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
        public string id
        {
            get;
            set;
        }

        /// <summary>
        /// The type of container to render.
        /// </summary>
        /// <remarks>
        /// The current player implementations support the following container types, however developers can define
        /// their own container types (but will need to make sure these are then supported in the player).
        /// 
        /// <ul>
        /// <li><strong>VERTICAL</strong>: All child page components and containers to this container should be oriented vertically (e.g. in rows).</li>
        /// <li><strong>HORIZONTAL</strong>: All child page components and containers to this container should be oriented horizontally (e.g. in columns or shift to rows if there’s not enough space).</li>
        /// <li><strong>INLINE:</strong> All child page components and containers to this container should be oriented inline (e.g. beside each other horizontally and “wrap” to the next line if there’s not enough space).</li>
        /// <li><strong>GROUP</strong>: All child page containers to this container should be grouped (e.g. each container in this container should appear as a tab).</li>
        /// </ul>
        /// </remarks>
        [DataMember]
        public string containerType
        {
            get;
            set;
        }

        /// <summary>
        /// The developer name for the page container. This will be used to identify the container in your layout, and
        /// this can be used to ease the creation of the page metadata. Developers should ensure that the developer name
        /// is unique for the page.
        /// </summary>
        [DataMember]
        public string developerName
        {
            get;
            set;
        }

        /// <summary>
        /// The label for this particular container. This will appear as a title heading to the running user(s).
        /// </summary>
        [DataMember]
        public string label
        {
            get;
            set;
        }

        /// <summary>
        /// The tree hierarchy of page containers that are children of this page container.
        /// </summary>
        [DataMember]
        public List<PageContainerAPI> pageContainers
        {
            get;
            set;
        }

        /// <summary>
        /// The order in which the page container should be rendered relative to its peers. The lowest number is
        /// rendered first.
        /// </summary>
        [DataMember]
        public int order
        {
            get;
            set;
        }

        /// <summary>
        /// Arbitrary key value pairs that may help the container render/execute. Use attributes to extend the page
        /// container metadata with implementation specific settings.
        /// </summary>
        [DataMember]
        public Dictionary<string, string> attributes
        {
            get;
            set;
        }

        /// <summary>
        /// The list of page tags that allow additional metadata to be applied to the page container. Conceptually tags
        /// can be used to mimic HTML and CSS but can also be used to provide data to enrich functionality of the page
        /// container.
        /// </summary>
        [DataMember]
        public List<PageTagAPI> tags
        {
            get;
            set;
        }
    }
}
