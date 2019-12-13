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
    public class NavigationItemAPI
    {
        /// <summary>
        /// The unique identifier for the NavigationItem. The id should be null for "insert" requests and a valid identifier for "update" requests. This property is created by the service.
        /// </summary>
        [DataMember]
        public string id
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the Map Element that this NavigationItem "points" to.
        /// </summary>
        [DataMember]
        public string locationMapElementId
        {
            get;
            set;
        }

        /// <summary>
        /// The developer name for the Navigation. This is useful for keeping track of the Navigation in the modeling tool and API.
        /// </summary>
        [DataMember]
        public string developerName
        {
            get;
            set;
        }

        /// <summary>
        /// The developer summary the author provided to give more information about the Navigation.
        /// </summary>
        [DataMember]
        public string developerSummary
        {
            get;
            set;
        }

        /// <summary>
        /// The label to display the user.
        /// </summary>
        [DataMember]
        public string label
        {
            get;
            set;
        }

        /// <summary>
        /// The navigation items that are available for this NavigationItem. The navigation items are the "links" the user can use to navigate around your Flow.
        /// </summary>
        [DataMember]
        public List<NavigationItemAPI> navigationItems
        {
            get;
            set;
        }

        /// <summary>
        /// The order in which this NavigationItem should appear in relation to other sibling NavigationItems.
        /// </summary>
        [DataMember]
        public int order
        {
            get;
            set;
        }

        /// <summary>
        /// The list of tags that are associated with this NavigationItem.
        /// </summary>
        [DataMember]
        public List<PageTagAPI> tags
        {
            get;
            set;
        }

         /// <summary>
        /// The list of values to reset that are associated with this navigation.
        /// </summary>
        [DataMember]
        public List<ValueToResetAPI> valuesToReset
        {
            get;
            set;
        }
    }
}
