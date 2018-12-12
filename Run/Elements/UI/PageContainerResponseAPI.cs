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

namespace ManyWho.Flow.SDK.Run.Elements.UI
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageContainerResponseAPI
    {
        /// <summary>
        /// The unique identifier for the page component. All page components have a property of pageContainerId that will match with this identifier to indicate that the component should be a child of this container.
        /// </summary>
        [DataMember]
        public string id
        {
            get;
            set;
        }

        /// <summary>
        /// The container type tells the player the kind of container that needs to be rendered. This is usually to indicate if the container has particular layour properties such as vertical, horizontal or inline flow - or that the container is a group of tabs. The container type is not restricted to the enumeration provided here - however - all of the standard players provided by ManyWho are able to render the container types in the enum. If you wish to add more container types, be aware that you will need to update the player to support these.
        /// </summary>
        [DataMember]
        public string containerType
        {
            get;
            set;
        }

        /// <summary>
        /// The name the author has given for this container.
        /// </summary>
        [DataMember]
        public string developerName
        {
            get;
            set;
        }

        /// <summary>
        /// The label for the container. This is often used as a title for the section of the page represented by this container.
        /// </summary>
        [DataMember]
        public string label
        {
            get;
            set;
        }

        /// <summary>
        /// The child scaffolding for this page container.
        /// </summary>
        [DataMember]
        public List<PageContainerResponseAPI> pageContainerResponses
        {
            get;
            set;
        }

        /// <summary>
        /// The order in which this container should appear on the page with respect to other page containers at the same level in the page container hierarchy.
        /// </summary>
        [DataMember]
        public int order
        {
            get;
            set;
        }

        [DataMember]
        public Dictionary<string, string> attributes
        {
            get;
            set;
        }
    }
}