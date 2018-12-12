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

namespace ManyWho.Flow.SDK.Draw.Elements.Map
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class MapElementAPI : ElementAPI
    {
        /// <summary>
        /// The unique identifier for the Group that contains this Map Element. If a Map Element is inside a Group, it inherits certain behaviors of the parent Group. For example, a Swimlane Group wraps all child Map Elements in a security context.
        /// </summary>
        [DataMember]
        public string groupElementId
        {
            get;
            set;
        }

        /// <summary>
        /// The x location of the Map Element on the Flow diagram.
        /// </summary>
        [DataMember]
        public int x
        {
            get;
            set;
        }

        /// <summary>
        /// The y location of the Map Element on the Flow diagram.
        /// </summary>
        [DataMember]
        public int y
        {
            get;
            set;
        }

        [DataMember]
        public string pageElementId
        {
            get;
            set;
        }

        /// <summary>
        /// The list of outcomes that are available for this Map Element. An Outcome is used to connect the flow of execution from one Map Element in the Flow to another. An Outcome can take the form of a Page button, but also define system steps such as rules.
        /// </summary>
        [DataMember]
        public List<OutcomeAPI> outcomes
        {
            get;
            set;
        }
    }
}