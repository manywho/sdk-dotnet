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

        /// <summary>
        /// The type of authentication being performed
        /// </summary>
        [DataMember]
        public string authenticationType
        {
            get;
            set;
        }

        /// <summary>
        /// The username for your account in the directory
        /// </summary>
        [DataMember]
        public string username
        {
            get;
            set;
        }

        /// <summary>
        /// The password for your account in the directory
        /// </summary>
        [DataMember]
        public string password
        {
            get;
            set;
        }

        /// <summary>
        /// The account token for the directory. For OAuth2 integration, this the access token
        /// </summary>
        [DataMember]
        public string token
        {
            get;
            set;
        }

        /// <summary>
        /// The OAuth2 code
        /// </summary>
        [DataMember]
        public string code
        {
            get;
            set;
        }

        /// <summary>
        /// The session token for the directory. For services such as salesforce.com, this is the sessionId
        /// </summary>
        [DataMember]
        public string sessionToken
        {
            get;
            set;
        }

        /// <summary>
        /// The session URL for the directory. For services such as salesforce.com, this is the pod instance you are currently logged into
        /// </summary>
        [DataMember]
        public string sessionUrl
        {
            get;
            set;
        }

        /// <summary>
        /// The REST endpoint for the plugin providing the identity
        /// </summary>
        [DataMember]
        public string loginUrl
        {
            get;
            set;
        }

        /// <summary>
        /// The OAuth2 redirect URI
        /// </summary>
        [DataMember]
        public string redirectUri
        {
            get;
            set;
        }

        /// <summary>
        /// The particular instance of the directory. For services such as salesforce.com, this is either "https://login.salesforce.com" (default) or "https://test.salesforce.com".
        /// </summary>
        [DataMember]
        public string instanceUrl
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

        /// <summary>
        /// The OAuth1.0 verifier
        /// </summary>
        [DataMember]
        public string verifier
        {
            get;
            set;
        }
    }
}
