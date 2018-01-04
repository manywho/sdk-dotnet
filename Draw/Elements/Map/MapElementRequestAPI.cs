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
    public class MapElementRequestAPI : MapElementAPI
    {
        /// <summary>
        /// The list of operations that should be performed when this Map Element executes. Operations are used to change the value of Values in the executing Flow (State).
        /// </summary>
        [DataMember]
        public List<OperationAPI> operations
        {
            get;
            set;
        }

        /// <summary>
        /// The list of listeners that should be registered when this Map Element executes.
        /// </summary>
        [DataMember]
        public List<ListenerAPI> listeners
        {
            get;
            set;
        }

        /// <summary>
        /// The view message action object defines the interface inputs/outputs for calling against a REMOTE_PAGE Map Element. For the REMOTE_PAGE, the page view is delivered by an external system - allowing developers to hand-code very complex UI scenarios.
        /// </summary>
        [DataMember]
        public MessageActionAPI viewMessageAction
        {
            get;
            set;
        }

        /// <summary>
        /// The list of message actions that should be executed when this Map Element executes. The message action objects define the interface of inputs/outputs for calling against each Service message.
        /// </summary>
        [DataMember]
        public List<MessageActionAPI> messageActions
        {
            get;
            set;
        }

        /// <summary>
        /// The list of data actions that should be executed when this map element executes. The data action objects
        /// define the values and bindings that should be used to perform CRUD operations against each service and value.
        /// </summary>
        [DataMember]
        public List<DataActionAPI> dataActions
        {
            get;
            set;
        }

        /// <summary>
        /// The list of navigation overrides that should be applied when this Map Element executes.
        /// </summary>
        [DataMember]
        public List<NavigationOverrideAPI> navigationOverrides
        {
            get;
            set;
        }

        /// <summary>
        /// The voting configuration that should be used for this Map Element. The voting algorithm is based on the authorization context of the Map Element and the Service that either the Flow or the Swimlane this Map Element is contained within.
        /// </summary>
        [DataMember]
        public VoteAPI vote
        {
            get;
            set;
        }

        [DataMember]
        public Boolean clearNavigationOverrides
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if this Map Element should post an update to the collaboration stream.
        /// </summary>
        [DataMember]
        public Boolean postUpdateToStream
        {
            get;
            set;
        }

        /// <summary>
        /// The content that should be shown to the user at this step in the Flow. This property should only be used for very simple Flows and informational UI. For anything more than simple messaging, use the Page and associate it with this Map Element using the pageElementId property.
        /// </summary>
        [DataMember]
        public String userContent
        {
            get;
            set;
        }

        /// <summary>
        /// The content that should be shown to the user while waiting for a system step to complete.
        /// </summary>
        [DataMember]
        public String statusMessage
        {
            get;
            set;
        }

        /// <summary>
        /// The content of the message that should be posted to the collaboration stream.
        /// </summary>
        [DataMember]
        public String postUpdateMessage
        {
            get;
            set;
        }

        /// <summary>
        /// The content that should be shown to the user if they are not authorized to take action on this Map Element.
        /// </summary>
        [DataMember]
        public String notAuthorizedMessage
        {
            get;
            set;
        }

        /// <summary>
        /// The point at which the post should be made to the collaboration stream.
        /// </summary>
        [DataMember]
        public String postUpdateWhenType
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the platform should attempt to find a Type with the same developer name as the one provided and match them up by name as opposed to 'id'. This is useful when creating scripts to create Flows - as you can use the developerName property as the reference as opposed to needing to know the ids of all created Elements.
        /// </summary>
        [DataMember]
        public Boolean updateByName
        {
            get;
            set;
        }
    }
}