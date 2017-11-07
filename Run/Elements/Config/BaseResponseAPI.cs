using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Translate;

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
    public class BaseResponseAPI
    {
        /// <summary>
        /// The execution token needed for any callback responses from the Service.
        /// </summary>
        [DataMember]
        public String token
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the tenant that made the request to the Service.
        /// </summary>
        [DataMember]
        public String tenantId
        {
            get;
            set;
        }

        /// <summary>
        /// The Culture of the Service sending the response back to ManyWho.
        /// </summary>
        [DataMember]
        public CultureAPI culture
        {
            get;
            set;
        }

        /// <summary>
        /// Any runtime annotations that were provided to the State plus any additional annotations the Service may be providing.
        /// </summary>
        [DataMember]
        public Dictionary<String, String> annotations
        {
            get;
            set;
        }
    }
}
