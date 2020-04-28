using System.Collections.Generic;
using System.Runtime.Serialization;
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
        public string joinPlayerUri
        {
            get;
            set;
        }

        /// <summary>
        /// Provides the caller with the URI for the player and the associated app.
        /// </summary>
        [DataMember]
        public string playerUri
        {
            get;
            set;
        }

        /// <summary>
        /// The Uri that was used to make this ServiceRequest.
        /// </summary>
        [DataMember]
        public string uri
        {
            get;
            set;
        }

        /// <summary>
        /// The array of inputs required to execute the message action specified in the Service description. The inputs may not be complete depending on the configuration of the MessageAction and/or the version of the description (ServiceActionRequest) that was used by the builder user when modeling.
        /// </summary>
        [DataMember]
        public List<EngineValueAPI> inputs
        {
            get;
            set;
        }

        /// <summary>
        /// Any outcomes that are connected from the messaging element in the Flow. These outcomes can be used by the Service in the response to select a desired path of execution.
        /// </summary>
        [DataMember]
        public List<OutcomeResponseAPI> outcomes
        {
            get;
            set;
        }

        [DataMember]
        public string executionMode
        {
            get;
            set;
        }
    }
}