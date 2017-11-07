using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.State;
using ManyWho.Flow.SDK.Run.Elements.Map;
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
    public class EngineInvokeRequestAPI
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
        public String stateId
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the token response from the state. The state token identifier changes with every cycle of request/response. The token is needed as it tells the engine how in-sync your request is with the current service side state.
        /// </summary>
        [DataMember]
        public String stateToken
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the map element the user is currently executing against.
        /// </summary>
        [DataMember]
        public String currentMapElementId
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the navigation element that's being used to drive the navigation scheme.
        /// </summary>
        [DataMember]
        public String navigationElementId
        {
            get;
            set;
        }

        /// <summary>
        /// When executing using an InvokeType of 'NAVIGATE', this is the selected navigation item the user wishes to move to in the Flow.
        /// </summary>
        [DataMember]
        public String selectedNavigationItemId
        {
            get;
            set;
        }

        /// <summary>
        /// When executing a Flow that has the allowJumping property set to 'true', the user can move to any Map Element in the Flow regardless of navigation or outcomes. This is the unique identifier of the Map Element the user wishes to navigate to and must be used with an InvokeType of 'NAVIGATE'.
        /// </summary>
        [DataMember]
        public String selectedMapElementId
        {
            get;
            set;
        }

        /// <summary>
        /// The way you want to invoke the engine as part of this request. The user may be navigating forward, or you may be wanting to perform a sync operation to update the UI due to another user making a change.
        /// </summary>
        [DataMember]
        public String invokeType
        {
            get;
            set;
        }

        /// <summary>
        /// Key value pairs you wish to annotate to the flow. Annotations take the form of {"mykey":"myvalue"}. Any annotations added to the state will be persisted for the duration of the flow. Annotations are passed to the executing player and also through to plugin services. Annotations can be changed at any time through the execution of the flow.
        /// </summary>
        [DataMember]
        public Dictionary<String, String> annotations
        {
            get;
            set;
        }

        /// <summary>
        /// An object representing the current location information of the calling user.
        /// </summary>
        [DataMember]
        public GeoLocationAPI geoLocation
        {
            get;
            set;
        }

        /// <summary>
        /// The map element invoke request holds the data that was collected from the user. This can be inputs from a form or simply the selected outcome (e.g. the button they clicked to move forward).
        /// </summary>
        [DataMember]
        public MapElementInvokeRequestAPI mapElementInvokeRequest
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
    }
}
