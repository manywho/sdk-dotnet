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

namespace ManyWho.Flow.SDK.Run.Elements.Config
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class AuthorizationGroupAPI
    {
        /// <summary>
        /// A unique identifier provided by the Service for the AuthorizationGroup. The AuthorizationGroup can represent any object in the underlying Service identity management system.
        /// </summary>
        [DataMember]
        public String authenticationId
        {
            get;
            set;
        }

        /// <summary>
        /// The attribute associated with the authentication identifier. The attributes are defined by the Service, but typically they're things like: MEMBER, OWNER, etc.
        /// </summary>
        [DataMember]
        public String attribute
        {
            get;
            set;
        }
    }
}
