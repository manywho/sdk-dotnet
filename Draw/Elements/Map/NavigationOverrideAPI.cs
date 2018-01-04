using System;
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

namespace ManyWho.Flow.SDK.Draw.Elements.Map
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class NavigationOverrideAPI
    {
        /// <summary>
        /// The unique identifier for the navigation this override is referencing.
        /// </summary>
        [DataMember]
        public String navigationElementId
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the specific navigation item in the navigation being referenced.
        /// </summary>
        [DataMember]
        public String navigationItemId
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the navigation item being referenced should be enabled. If the navigation item has
        /// <code>isEnabled</code> set to <code>false</code>, the user will see the navigation item, but it will not
        /// function.
        /// </summary>
        [DataMember]
        public Boolean isEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the navigation item being referenced should be visible. If the navigation item has
        /// <code>isVisible</code> set to <code>false</code>, it will no longer appear to the user in the navigation.
        /// This will include child navigation items.
        /// </summary>
        [DataMember]
        public Boolean isVisible
        {
            get;
            set;
        }

        /// <summary>
        /// The map element that the navigation item should point to based on this override.
        /// </summary>
        [DataMember]
        public String locationMapElementId
        {
            get;
            set;
        }

        [DataMember]
        public string locationMapElementDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public string navigationElementDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public string navigationItemDeveloperName
        {
            get;
            set;
        }
    }
}
