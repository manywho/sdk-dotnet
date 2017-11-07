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
    public class PageElementRequestAPI : PageElementAPI
    {
        /// <summary>
        /// The top most label for the Page Element. This is usually used as the title of the Page.
        /// </summary>
        [DataMember]
        public String label
        {
            get;
            set;
        }

        /// <summary>
        /// The tree hierarchy of page containers that define the scaffolding of the page layout. Conceptually, page containers are similar to HTML5 'div' tags. If no page containers are provided, it is assumed that all components will be oriented in a vertical flow layout.
        /// </summary>
        [DataMember]
        public List<PageContainerAPI> pageContainers
        {
            get;
            set;
        }

        /// <summary>
        /// The list of components to be embedded on the page. Each component is associated with a page container for relative positioning information. Conceptually, page containers are similar to HTML5 form controls and/or specific layout blocks containing images or content.
        /// </summary>
        [DataMember]
        public List<PageComponentAPI> pageComponents
        {
            get;
            set;
        }

        /// <summary>
        /// The list of page conditions that set out the rules that should be evaluated and the actions that should be taken if those rules evaluate to 'true'. Page conditions make it possible to define complex UI event models.
        /// </summary>
        [DataMember]
        public List<PageConditionAPI> pageConditions
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the engine should continue to execute rules and actions on the page if a condition evaluates to 'true. This makes it possible to deal with page rules that may conflict if all run for all events on the page.
        /// </summary>
        [DataMember]
        public Boolean stopConditionsOnFirstTrue
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
        /// The list of page tags that allow additional metadata to be applied to various page objects: components, controls and the overall page. Conceptually tags can be used to mimic HTML and CSS but can also be used to provide data to enrich functionality on the page.
        /// </summary>
        [DataMember]
        public List<PageTagAPI> tags
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the platform should attempt to find a Page Element with the same developer name as the one provided and match them up by name as opposed to 'id'. This is useful when creating scripts to create Flows - as you can use the developerName property as the reference as opposed to needing to know the ids of all created Elements.
        /// </summary>
        [DataMember]
        public Boolean updateByName
        {
            get;
            set;
        }
    }
}
