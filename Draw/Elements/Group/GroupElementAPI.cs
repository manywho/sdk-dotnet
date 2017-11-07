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
        [DataMember]
        public String groupElementId
        {
            get;
            set;
        }

        /// <summary>
        /// The x location of the Group on the Flow diagram.
        /// </summary>
        [DataMember]
        public Int32 x
        {
            get;
            set;
        }

        /// <summary>
        /// The y location of the Group on the Flow diagram.
        /// </summary>
        [DataMember]
        public Int32 y
        {
            get;
            set;
        }

        /// <summary>
        /// The height of the Group on the Flow diagram.
        /// </summary>
        [DataMember]
        public Int32 height
        {
            get;
            set;
        }

        /// <summary>
        /// The width of the Group on the Flow diagram.
        /// </summary>
        [DataMember]
        public Int32 width
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
