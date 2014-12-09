using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Group;
using ManyWho.Flow.SDK.Translate;
using ManyWho.Flow.SDK.Run.Elements.Map;

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
    public class BaseRequestAPI
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
        /// The tenant from which this service request eminated.
        /// </summary>
        [DataMember]
        public String tenantId
        {
            get;
            set;
        }

        /// <summary>
        /// The state for which this service request is associated.
        /// </summary>
        [DataMember]
        public String stateId
        {
            get;
            set;
        }

        /// <summary>
        /// The Uri for any callbacks from the remote service.
        /// </summary>
        [DataMember]
        public String callbackUri
        {
            get;
            set;
        }

        /// <summary>
        /// The culture for the service request.
        /// </summary>
        [DataMember]
        public CultureAPI culture
        {
            get;
            set;
        }

        /// <summary>
        /// The configuration information needed for the service to function.
        /// </summary>
        [DataMember]
        public List<EngineValueAPI> configurationValues
        {
            get;
            set;
        }

        /// <summary>
        /// The authorization context the message is running within. If we're running identity with the same service, this will tell the user
        /// which users are currently authorized. The purpose of this property is to help with notifications - not to restrict access - that is
        /// managed by the ManyWho engine.
        /// </summary>
        [DataMember]
        public GroupAuthorizationAPI authorization
        {
            get;
            set;
        }

        /// <summary>
        /// We pass the annotations as part of the service request.
        /// </summary>
        [DataMember]
        public Dictionary<String, String> annotations
        {
            get;
            set;
        }

        /// <summary>
        /// Any additional metadata that might be helpful to tell the service what to do.
        /// </summary>
        [DataMember]
        public Dictionary<String, String> attributes
        {
            get;
            set;
        }
    }
}
