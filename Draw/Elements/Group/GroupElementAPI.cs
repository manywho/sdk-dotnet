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

namespace ManyWho.Flow.SDK.Draw.Elements.Group
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class GroupElementAPI : ElementAPI
    {
        /// <summary>
        /// The unique identifier for the group element that holds this group element.
        /// </summary>
        /// <remarks>
        /// The swimlane group element does not support nested groupings.
        /// </remarks>
        [DataMember]
        public string groupElementId
        {
            get;
            set;
        }

        /// <summary>
        /// The x location of the Group on the Flow diagram.
        /// </summary>
        [DataMember]
        public int x
        {
            get;
            set;
        }

        /// <summary>
        /// The y location of the Group on the Flow diagram.
        /// </summary>
        [DataMember]
        public int y
        {
            get;
            set;
        }

        /// <summary>
        /// The height of the Group on the Flow diagram.
        /// </summary>
        [DataMember]
        public int height
        {
            get;
            set;
        }

        /// <summary>
        /// The width of the Group on the Flow diagram.
        /// </summary>
        [DataMember]
        public int width
        {
            get;
            set;
        }

        /// <summary>
        /// The Authorization object for this Group.
        /// </summary>
        [DataMember]
        public GroupAuthorizationAPI authorization
        {
            get;
            set;
        }
    }
}
