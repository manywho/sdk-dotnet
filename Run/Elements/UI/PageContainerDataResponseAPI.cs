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
    public class PageContainerDataResponseAPI
    {
        /// <summary>
        /// The unique identifier for the page container that this data pertains to.
        /// </summary>
        [DataMember]
        public String pageContainerId
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the page container should be enabled. If the page container is disabled, the default behavior is that all child components and containers are also disabled.
        /// </summary>
        [DataMember]
        public Boolean isEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the page container should be editable. If the page container is not editable, the default behavior is that all child components and containers are also not editable.
        /// </summary>
        [DataMember]
        public Boolean isEditable
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the page container should be visible. If the page container is not visible, the default behavior is that all child components and containers are also not visible.
        /// </summary>
        [DataMember]
        public Boolean isVisible
        {
            get;
            set;
        }

        /// <summary>
        /// The page tag provides additional metadata that the author of the flow has defined for this container. Tags are a very powerful way of providing additional information to player developers to ensure the app is providing exactly the user experience you expect. This object will be further documented when we release the page composition tool.
        /// </summary>
        [DataMember]
        public List<EngineValueAPI> tags
        {
            get;
            set;
        }
    }
}
