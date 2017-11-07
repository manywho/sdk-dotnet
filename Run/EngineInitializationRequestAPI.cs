using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Flow;

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

namespace ManyWho.Flow.SDK.Run
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class EngineInitializationRequestAPI
    {
        /// <summary>
        /// The complete unique identifier for the Flow you want to initialize. The Flow identifier must include the version information.
        /// </summary>
        [DataMember]
        public FlowIdAPI flowId
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for an existing State. This parameter should be used if the first initialization request was rejected due to access being denied due to authentication. If you do not re-use this stateId property, your inputs will not be correctly assigned.
        /// </summary>
        [DataMember]
        public String stateId
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the parent State that "spawned" this State. This property is assigned when a Flow calls a Sub-Flow. The Sub-Flow will have this property assigned referencing the parent Flow.
        /// </summary>
        [DataMember]
        public String parentStateId
        {
            get;
            set;
        }

        /// <summary>
        /// An arbitrary external identifier that can be used to query for a State.
        /// </summary>
        [DataMember]
        public String externalIdentifier
        {
            get;
            set;
        }

        /// <summary>
        /// Annotations take the form of {"mykey":"myvalue"}. Any annotations added to the State will be persisted for the duration of the Flow. Annotations are passed to the executing player and also through to Services. Annotations can be changed at any time through the execution of the Flow.
        /// </summary>
        [DataMember]
        public Dictionary<String, String> annotations
        {
            get;
            set;
        }

        /// <summary>
        /// An array of engine value objects that will be used to assign values in the flow at initialization.
        /// </summary>
        [DataMember]
        public List<EngineValueAPI> inputs
        {
            get;
            set;
        }

        /// <summary>
        /// The location of the player that should be used for sharing and notifications when first running the flow. The service will automatically append the "flow-id" parameter to this url so the player knows which flow it is playing.
        /// </summary>
        [DataMember]
        public String playerUrl
        {
            get;
            set;
        }

        /// <summary>
        /// The location of the player that should be used for sharing and notifications when joining a running flow. The service will automatically append the "join" parameter to this url so the player knows which flow and state it is playing (the "join" parameter is the state identifier).
        /// </summary>
        [DataMember]
        public String joinPlayerUrl
        {
            get;
            set;
        }

        /// <summary>
        /// The mode you wish to run the flow in. The mode is mainly useful for debugging purposes as you can step through the flow and also view state information to check everything is working as expected.
        /// </summary>
        [DataMember]
        public String mode
        {
            get;
            set;
        }

        /// <summary>
        /// The reporting mode under which you want to run this State of a Flow.
        /// </summary>
        [DataMember]
        public String reportingMode
        {
            get;
            set;
        }
    }
}
