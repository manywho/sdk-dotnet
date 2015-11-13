using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Flow;
using ManyWho.Flow.SDK.Draw.Log;

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

namespace ManyWho.Flow.SDK.Run.State
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class StateAPI
    {
        [DataMember]
        public String id
        {
            get;
            set;
        }

        [DataMember]
        public String parentId
        {
            get;
            set;
        }

        [DataMember]
        public DateTime dateCreated
        {
            get;
            set;
        }

        [DataMember]
        public DateTime dateModified
        {
            get;
            set;
        }

        [DataMember]
        public FlowIdAPI currentFlowId
        {
            get;
            set;
        }

        [DataMember]
        public String currentFlowDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public String currentMapElementId
        {
            get;
            set;
        }

        [DataMember]
        public String currentMapElementDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public String currentStreamId
        {
            get;
            set;
        }

        [DataMember]
        public String currentRunningUserId
        {
            get;
            set;
        }

        [DataMember]
        public string currentRunningUserEmail
        {
            get;
            set;
        }

        [DataMember]
        public String externalIdentifier
        {
            get;
            set;
        }

        [DataMember]
        public String manywhoTenantId
        {
            get;
            set;
        }

        [DataMember]
        public Dictionary<String, String> annotations
        {
            get;
            set;
        }

        [DataMember]
        public List<StateEntryAPI> stateEntries
        {
            get;
            set;
        }

        [DataMember]
        public StateEntryAPI precommitStateEntry
        {
            get;
            set;
        }

        [DataMember]
        public List<StateValueAPI> values
        {
            get;
            set;
        }

        [DataMember]
        public String authorizationHeader
        {
            get;
            set;
        }

        [DataMember]
        public bool isDone
        {
            get;
            set;
        }

        [DataMember]
        public LogAPI log
        {
            get;
            set;
        }
    }
}
