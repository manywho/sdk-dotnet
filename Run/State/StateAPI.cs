using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Flow;
using ManyWho.Flow.SDK.Draw.Log;
using ManyWho.Flow.SDK.Run.Flow;

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
        public string id
        {
            get;
            set;
        }

        [DataMember]
        public string parentId
        {
            get;
            set;
        }

        [DataMember]
        public DateTimeOffset dateCreated
        {
            get;
            set;
        }

        [DataMember]
        public DateTimeOffset dateModified
        {
            get;
            set;
        }

        [DataMember]
        public DateTimeOffset? expiresAt
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
        public string currentFlowDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public string currentMapElementId
        {
            get;
            set;
        }

        [DataMember]
        public string currentMapElementDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public string currentStreamId
        {
            get;
            set;
        }

        [DataMember]
        public string currentRunningUserId
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
        public string externalIdentifier
        {
            get;
            set;
        }

        [DataMember]
        public string manywhoTenantId
        {
            get;
            set;
        }

        [DataMember]
        public Dictionary<string, string> annotations
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
        public string authorizationHeader
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
        public bool isExpired
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

        [DataMember]
        public string joinUri
        {
            get;
            set;
        }

        [DataMember]
        public Dictionary<string, string> rootFaults
        {
            get;
            set;
        }

        [DataMember]
        public bool hasRootFaults => rootFaults != null && rootFaults.Count > 0;
        
        [DataMember]
        public string storeId
        {
            get;
            set;
        }
        
        [DataMember]
        public List<FlowStackFrameAPI> frames
        {
            get; 
            set;
        }
    }
}
