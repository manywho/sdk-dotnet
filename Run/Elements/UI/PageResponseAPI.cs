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
    public class PageResponseAPI
    {
        /// <summary>
        /// The label for the page. This is often used as a title for the page.
        /// </summary>
        [DataMember]
        public String label
        {
            get;
            set;
        }

        /// <summary>
        /// The scaffolding for the page UI containers. The page containers are nested objects that give the complete heirarchy of containers that make up the layour of the UI. The engine will only return this array of objects for a "JOIN" or "FORWARD" invokeType. For all other types, we assume the player has the UI layout and therefore is only needing metadata and content/data updates. The engine will always provide the complete page scaffolding and then rely on the data responses to hide, display, disable, etc.
        /// </summary>
        [DataMember]
        public List<PageContainerResponseAPI> pageContainerResponses
        {
            get;
            set;
        }

        /// <summary>
        /// The UI component base structures. The data contained in this object will not change based on events. As with the page container response objects, this data is only provided when the engine is called with an invokeType of "JOIN" or "FORWARD".
        /// </summary>
        [DataMember]
        public List<PageComponentResponseAPI> pageComponentResponses
        {
            get;
            set;
        }

        /// <summary>
        /// The meta data and data for the page components. The metadata tells the player if the component is visible, enabled, etc, and also tells the player the content of the component. This information is subject to change based on events performed by the UI and this array of objects will always be returned by the engine regardless of invokeType (assuming the user is authenticated and the element has UI).
        /// </summary>
        [DataMember]
        public List<PageComponentDataResponseAPI> pageComponentDataResponses
        {
            get;
            set;
        }

        /// <summary>
        /// The meta data for the page containers. The metadata tells the player if the container is visible, enabled, etc. This information is subject to change based on events performed by the UI and this array of objects will always be returned by the engine regardless of invokeType (assuming the user is authenticated and the element has UI).
        /// </summary>
        [DataMember]
        public List<PageContainerDataResponseAPI> pageContainerDataResponses
        {
            get;
            set;
        }

        [DataMember]
        public List<EngineValueAPI> tags
        {
            get;
            set;
        }

        [DataMember]
        public Dictionary<String, String> attributes
        {
            get;
            set;
        }

        /// <summary>
        /// The order in which this page element should appear. The order will always be zero for the page element as it is the root container.
        /// </summary>
        [DataMember]
        public Int32 order
        {
            get;
            set;
        }
    }
}