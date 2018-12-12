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

namespace ManyWho.Flow.SDK.Draw.Elements.Map
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class MessageActionAPI
    {
        /// <summary>
        /// The developer name to help identify this message action in tooling and APIs.
        /// </summary>
        [DataMember]
        public string developerName
        {
            get;
            set;
        }

        /// <summary>
        /// The ID of the service that this message action will be executed against. The service also defines the list
        /// inputs/outputs that need to be configured for this message action.
        /// </summary>
        [DataMember]
        public string serviceElementId
        {
            get;
            set;
        }

        /// <summary>
        /// The unique URI part that should be used when invoking the service. The URI part will inform the service
        /// implementation which message action you are executing against.
        /// </summary>
        [DataMember]
        public string uriPart
        {
            get;
            set;
        }

        /// <summary>
        /// The list of message inputs that should be sent to the service when this action is invoked. The list of
        /// inputs is defined by the service.
        /// </summary>
        [DataMember]
        public List<MessageInputAPI> inputs
        {
            get;
            set;
        }

        /// <summary>
        /// The list of message outputs that should be sent back from the service and applied to values in the executing
        /// flow state. The list of outputs is defined by the service.
        /// </summary>
        [DataMember]
        public List<MessageOutputAPI> outputs
        {
            get;
            set;
        }

        /// <summary>
        /// Arbitrary key value pairs that may help the service execute the message action.
        /// </summary>
        /// <remarks>
        /// Use attributes to extend the message action metadata with implementation specific settings.
        /// </remarks>
        [DataMember]
        public Dictionary<string, string> attributes
        {
            get;
            set;
        }

        /// <summary>
        /// The order in which the message action should be performed in relation to other message actions. If message
        /// actions have the same order, they will be performed in parallel to improve flow performance.
        /// </summary>
        [DataMember]
        public int order
        {
            get;
            set;
        }

        [DataMember]
        public string serviceActionName
        {
            get;
            set;
        }

        /// <summary>
        /// Whether the message action is disabled or not
        /// </summary>
        [DataMember]
        public bool disabled
        {
            get;
            set;
        }
    }
}