using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.Elements.UI;
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

namespace ManyWho.Flow.SDK.Run
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class EngineInitializationResponseAPI
    {
        /// <summary>
        /// The internationalization Culture of the user or the current workflow State.
        /// </summary>
        [DataMember]
        public CultureAPI culture
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the initialized flow state. The state identifier is needed throughout the execution of the flow as it is the pointer that points the engine to the correct running instance of a flow.
        /// </summary>
        [DataMember]
        public string stateId
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the token response from the state. The state token identifier changes with every cycle of request/response. The token is needed as it tells the engine how in-sync your request is with the current service side state.
        /// </summary>
        [DataMember]
        public string stateToken
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the map element the user is currently executing against. When initializing the flow, this will be the start element for the flow if the user has authenticated correctly, otherwise, this will be null.
        /// </summary>
        [DataMember]
        public string currentMapElementId
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the collaboration stream associated with this flow. This identifier allows you to make calls against the "social" APIs to get the posts and comments associated with the flow. The stream identifier can change as you progress through the flow.
        /// </summary>
        [DataMember]
        public string currentStreamId
        {
            get;
            set;
        }

        /// <summary>
        /// The values mimic standard REST codes, but as a String. A "200" indicates the user is authenticated to execute the flow. A "401" indicates the user needs to login based on the authorization context information provided in the response.
        /// </summary>
        [DataMember]
        public string statusCode
        {
            get;
            set;
        }

        /// <summary>
        /// The authorization context for the initialization. This object will tell you how to login to the correct system to begin executing the flow.
        /// </summary>
        [DataMember]
        public EngineAuthorizationContextAPI authorizationContext
        {
            get;
            set;
        }

        /// <summary>
        /// The list of available navigation element references. These are the navigation schemes that can be used for this particular executing Flow.
        /// </summary>
        [DataMember]
        public List<NavigationElementReferenceAPI> navigationElementReferences
        {
            get;
            set;
        }
    }
}
