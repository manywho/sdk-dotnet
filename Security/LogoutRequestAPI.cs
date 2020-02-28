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

using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run;

namespace ManyWho.Flow.SDK.Security
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class LogoutRequestAPI
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
        /// The type of logout being performed (e.g. SAML)
        /// </summary>
        [DataMember]
        public string authenticationType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The authentication protocol (e.g. SAML) code
        /// </summary>
        [DataMember]
        public string code
        {
            get;
            set;
        }
        
        /// <summary>
        /// The REST endpoint for the identity provider
        /// </summary>
        [DataMember]
        public string logoutUrl
        {
            get;
            set;
        }
        
        /// <summary>
        /// The tenant ID
        /// </summary>
        [DataMember]
        public string tenantId
        {
            get;
            set;
        }
    }
}