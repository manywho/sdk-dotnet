using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run;

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

namespace ManyWho.Flow.SDK.Security
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class AuthenticationCredentialsAPI
    {
        /// <summary>
        /// Any additional configuration values that may have been applied by the engine to help with authentication.
        /// </summary>
        [DataMember]
        public List<EngineValueAPI> configurationValues
        {
            get;
            set;
        }

        [DataMember]
        public String authenticationType
        {
            get;
            set;
        }

        [DataMember]
        public String username
        {
            get;
            set;
        }

        [DataMember]
        public String password
        {
            get;
            set;
        }

        [DataMember]
        public String token
        {
            get;
            set;
        }

        [DataMember]
        public String code
        {
            get;
            set;
        }

        [DataMember]
        public String sessionToken
        {
            get;
            set;
        }

        [DataMember]
        public String sessionUrl
        {
            get;
            set;
        }

        [DataMember]
        public String loginUrl
        {
            get;
            set;
        }

        [DataMember]
        public String redirectUri
        {
            get;
            set;
        }

        [DataMember]
        public String instanceUrl
        {
            get;
            set;
        }

        [DataMember]
        public string tenantId
        {
            get;
            set;
        }
    }
}
