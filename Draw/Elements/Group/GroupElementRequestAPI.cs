﻿using System.Runtime.Serialization;

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

namespace ManyWho.Flow.SDK.Draw.Elements.Group
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class GroupElementRequestAPI : GroupElementAPI
    {
        /// <summary>
        /// Indicates if the platform should attempt to find a group with the same developer name as the one provided
        /// and match them up by name as opposed to by ID.
        /// </summary>
        /// <remarks>
        /// This is useful when writing scripts to create flows, as you can use the <code>developerName</code> property
        /// as the reference as opposed to needing to know the IDs of all created elements.
        /// </remarks>
        [DataMember]
        public bool updateByName
        {
            get;
            set;
        }
    }
}
