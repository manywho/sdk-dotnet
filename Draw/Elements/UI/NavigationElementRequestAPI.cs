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
    public class NavigationElementRequestAPI : NavigationElementAPI
    {
        /// <summary>
        /// The label to display the user.
        /// </summary>
        [DataMember]
        public String label
        {
            get;
            set;
        }

        /// <summary>
        /// The navigation items that are available for this Navigation. The navigation items are the "links" the user can use to navigate around your Flow.
        /// </summary>
        [DataMember]
        public List<NavigationItemAPI> navigationItems
        {
            get;
            set;
        }

        /// <summary>
        /// The list of tags that are associated with this Navigation.
        /// </summary>
        [DataMember]
        public List<PageTagAPI> tags
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the platform should attempt to find a Navigation with the same developer name as the one provided and match them up by name as opposed to 'id'. This is useful when creating scripts to create Flows - as you can use the developerName property as the reference as opposed to needing to know the ids of all created Elements.
        /// </summary>
        [DataMember]
        public Boolean updateByName
        {
            get;
            set;
        }
    }
}
