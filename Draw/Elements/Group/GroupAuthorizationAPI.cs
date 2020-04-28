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

namespace ManyWho.Flow.SDK.Draw.Elements.Group
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class GroupAuthorizationAPI
    {
        /// <summary>
        /// The unique identifier for the Service that this authorization configuration is associated. The Service must support identity.
        /// </summary>
        [DataMember]
        public string serviceElementId
        {
            get;
            set;
        }

        /// <summary>
        /// The global authentication type for this Flow.
        /// </summary>
        [DataMember]
        public string globalAuthenticationType
        {
            get;
            set;
        }

        /// <summary>
        /// The stream behaviour type for this Flow.
        /// </summary>
        [DataMember]
        public string streamBehaviourType
        {
            get;
            set;
        }

        /// <summary>
        /// Whether to display page fields as read only
        /// </summary>
        [DataMember]
        public bool showPagesAsReadOnly
        {
            get;
            set;
        }

        /// <summary>
        /// The list of groups that are associated with this authorization configuration.
        /// </summary>
        [DataMember]
        public List<GroupAuthorizationGroupAPI> groups
        {
            get;
            set;
        }

        /// <summary>
        /// The list of users that are associated with this authorization configuration.
        /// </summary>
        [DataMember]
        public List<GroupAuthorizationUserAPI> users
        {
            get;
            set;
        }

        /// <summary>
        /// The list of locations that are associated with this authorization configuration.
        /// </summary>
        [DataMember]
        public List<GroupAuthorizationLocationAPI> locations
        {
            get;
            set;
        }
    }
}
