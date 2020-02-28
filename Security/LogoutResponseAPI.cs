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

using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Security
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class LogoutResponseAPI
    {
        /// <summary>
        /// The userId for your account in the directory
        /// </summary>
        [DataMember]
        public string userId
        {
            get;
            set;
        }
        
        /// <summary>
        /// The response status
        /// </summary>
        [DataMember]
        public string status
        {
            get;
            set;
        }
        
        /// <summary>
        /// The response error message (if any)
        /// </summary>
        [DataMember]
        public string errorMessage
        {
            get;
            set;
        }
        
        /// <summary>
        /// The identity protocol (e.g. SAML) code
        /// </summary>
        [DataMember]
        public string code
        {
            get;
            set;
        }
    }
}