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
        /// The token for this service request.  The token is needed for the service execution manager to identify the correct state.
        /// </summary>
        [DataMember]
        public String token
        {
            get;
            set;
        }

        /// <summary>
        /// The tenant for which the response applies.
        /// </summary>
        [DataMember]
        public String tenantId
        {
            get;
            set;
        }

        /// <summary>
        /// The culture for the response.
        /// </summary>
        [DataMember]
        public CultureAPI culture
        {
            get;
            set;
        }

        /// <summary>
        /// Passes back any annotations to the service.
        /// </summary>
        [DataMember]
        public Dictionary<String, String> annotations
        {
            get;
            set;
        }
    }
}
