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

namespace ManyWho.Flow.SDK.Security
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class RemoteSiteAPI
    {
        /// <summary>
        /// The name for this remote site restriction
        /// </summary>
        [DataMember]
        public String developerName
        {
            get;
            set;
        }

        /// <summary>
        /// Any additional summary information about this remote site restriction
        /// </summary>
        [DataMember]
        public String developerSummary
        {
            get;
            set;
        }

        /// <summary>
        /// The base Uri for the remote site (e.g. https://flow.manywho.com)
        /// </summary>
        [DataMember]
        public String uri
        {
            get;
            set;
        }

        /// <summary>
        /// A boolean value indicating if requests to this remote site can be made without SSL encryption
        /// </summary>
        [DataMember]
        public Boolean disableProtocolSecurity
        {
            get;
            set;
        }
    }
}
