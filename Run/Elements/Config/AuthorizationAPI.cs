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

namespace ManyWho.Flow.SDK.Run.Elements.Config
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class AuthorizationAPI
    {
        /// <summary>
        /// An array containing the list of Users that are authorized to access this part of the Flow.
        /// </summary>
        [DataMember]
        public List<AuthorizationUserAPI> users
        {
            get;
            set;
        }

        /// <summary>
        /// An array containing the list of Groups that are authorized to access this part of the Flow.
        /// </summary>
        [DataMember]
        public List<AuthorizationGroupAPI> groups
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier of the assigned "running user". This is not necessarily the user currently accessing the Flow, but rather the reference user identifier that should be used for relationships such as "Manager" or "Colleague" when moving from one authentication context to another.
        /// </summary>
        [DataMember]
        public string runningAuthenticationId
        {
            get;
            set;
        }

        /// <summary>
        /// The overall authentication type that should be used when authorizing users.
        /// </summary>
        [DataMember]
        public string globalAuthenticationType
        {
            get;
            set;
        }
    }
}
