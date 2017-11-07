using System;
using System.Collections.Generic;
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

namespace ManyWho.Flow.SDK.Run.Elements.Config
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ServiceResponseAPI : BaseResponseAPI
    {
        /// <summary>
        /// Tells the engine what this service would like it to do.  At the moment, there are really only
        /// two possible commands: WAIT (to tell the engine to wait for a completed response) or DONE (to
        /// tell the engine that it has completed its work.
        /// </summary>
        [DataMember]
        public String invokeType
        {
            get;
            set;
        }

        /// <summary>
        /// The "wait" message that should be provided to users waiting for the Service to complete its tasks.
        /// </summary>
        [DataMember]
        public String waitMessage
        {
            get;
            set;
        }

        /// <summary>
        /// The output values from the Service being sent back to the Flow State. Outputs will be applied to the Flow State even if the InvokeType is set to WAIT.
        /// </summary>
        [DataMember]
        public List<EngineValueAPI> outputs
        {
            get;
            set;
        }

        /// <summary>
        /// The Outcome the Service would like the Flow to follow. If the Outcome has Rules, the Service request for this outcome will be ignored unless the Rules are also satisfied.
        /// </summary>
        [DataMember]
        public String selectedOutcomeId
        {
            get;
            set;
        }

        /// <summary>
        /// Any faults that have happened in the Service that should be reported up to the Flow State.
        /// </summary>
        [DataMember]
        public Dictionary<String, String> rootFaults
        {
            get;
            set;
        }

        /// <summary>
        /// Any faults that are directly attributed to an input value provided in the ServiceRequest. If a ValueFault is specified, ManyWho will attempt to match this error with any input fields that are bound to that Value.
        /// </summary>
        [DataMember]
        public List<ValueFaultAPI> valueFaults
        {
            get;
            set;
        }

        /// <summary>
        /// The mode which the Service would like the Flow State to execute under.
        /// </summary>
        [DataMember]
        public String mode
        {
            get;
            set;
        }
    }
}