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
        public String developerName
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the Service that this message action will be executed against. The Service also defines the list inputs/outputs that need to be configured for this message action.
        /// </summary>
        [DataMember]
        public String serviceElementId
        {
            get;
            set;
        }

        /// <summary>
        /// The unique Uri part that should be used when invoking the Service. The Uri part will inform the Service implementation which message action you are executing against.
        /// </summary>
        [DataMember]
        public String uriPart
        {
            get;
            set;
        }

        /// <summary>
        /// The list of message inputs that should be sent to the Service when this action is invoked. The list of inputs is defined by the Service.
        /// </summary>
        [DataMember]
        public List<MessageInputAPI> inputs
        {
            get;
            set;
        }

        /// <summary>
        /// The list of message outputs that should be sent back from the Service and applied to Values in the executing Flow (State). The list of outputs is defined by the Service.
        /// </summary>
        [DataMember]
        public List<MessageOutputAPI> outputs
        {
            get;
            set;
        }

        /// <summary>
        /// Arbitrary key value pairs that may help the Service execute the MessageAction. Use attributes to extend our MessageAction metadata with implementation specific settings.
        /// </summary>
        [DataMember]
        public Dictionary<String, String> attributes
        {
            get;
            set;
        }

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