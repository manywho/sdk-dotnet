using System;
using System.Collections.Generic;
using System.Linq;
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
    public class ServiceRequestAPI : BaseRequestAPI
    {
        /// <summary>
        /// Provides the caller with the URI for the player this flow is currently using to run.
        /// </summary>
        [DataMember]
        public String joinPlayerUri
        {
            get;
            set;
        }

        /// <summary>
        /// Provides the caller with the URI for the player and the associated app.
        /// </summary>
        [DataMember]
        public String playerUri
        {
            get;
            set;
        }

        /// <summary>
        /// The Uri for the service to invoke.
        /// </summary>
        [DataMember]
        public String uri
        {
            get;
            set;
        }

        /// <summary>
        /// The inputs for the service.
        /// </summary>
        [DataMember]
        public List<EngineValueAPI> inputs
        {
            get;
            set;
        }

        /// <summary>
        /// The outcomes that are available for this element. The system can return it's desired selected outcome in addition to sending back outputs.
        /// </summary>
        [DataMember]
        public List<OutcomeAvailableAPI> outcomes
        {
            get;
            set;
        }
    }
}