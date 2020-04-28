using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.Elements.UI;

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

namespace ManyWho.Flow.SDK.Run.Elements.Map
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class MapElementInvokeResponseAPI
    {
        /// <summary>
        /// The unique identifier for the map element this response pertains to.
        /// </summary>
        [DataMember]
        public string mapElementId
        {
            get;
            set;
        }

        /// <summary>
        /// The developer name for the map element this response pertains to.
        /// </summary>
        [DataMember]
        public string developerName
        {
            get;
            set;
        }

        /// <summary>
        /// The meta data object for the page. This object should be used to generate the UI that will be presented to the user. If the map element invoke response contains a pageResponse object, then the engine is expecting the user to take action to progress the state of the flow.
        /// </summary>
        [DataMember]
        public PageResponseAPI pageResponse
        {
            get;
            set;
        }

        /// <summary>
        /// The outcome response objects are the actions that can be performed by the user to navigate the flow from element to element. Outcome responses can be bound to page components to add additional context to the action (e.g. the button should appear beside a field input, above a table of records, etc)
        /// </summary>
        [DataMember]
        public List<OutcomeResponseAPI> outcomeResponses
        {
            get;
            set;
        }

        /// <summary>
        /// Key value pairs taking the form of {"errorCode":"errorMessage"}. The root faults are populated if a fault has occurred that is not attributed to a specific value on the page. A root fault is often due to an element in the flow experiencing a fault and the author of the flow has determined that the user should be navigated to this page to rectify the problem. If an error is attributed to a value in the state, it will be bound to the page component as a validation error message.
        /// </summary>
        [DataMember]
        public Dictionary<string, string> rootFaults
        {
            get;
            set;
        }
    }
}
