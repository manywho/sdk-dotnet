using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManyWho.Flow.SDK.Run;
using ManyWho.Flow.SDK.Run.State;
using ManyWho.Flow.SDK.Run.Elements.UI;
using ManyWho.Flow.SDK.Run.Elements.Map;
using ManyWho.Flow.SDK.Draw.Elements.Map;
using ManyWho.Flow.SDK.Translate;
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

namespace ManyWho.Flow.SDK.Run
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class EngineInvokeResponseAPI
    {
        [DataMember]
        public CultureAPI culture
        {
            get;
            set;
        }

        [DataMember]
        public String stateId
        {
            get;
            set;
        }

        [DataMember]
        public String parentStateId
        {
            get;
            set;
        }

        [DataMember]
        public String stateToken
        {
            get;
            set;
        }

        [DataMember]
        public String alertEmail
        {
            get;
            set;
        }

        [DataMember]
        public String waitMessage
        {
            get;
            set;
        }

        [DataMember]
        public String notAuthorizedMessage
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
        public String currentStreamId
        {
            get;
            set;
        }

        [DataMember]
        public String invokeType
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
        public List<MapElementInvokeResponseAPI> mapElementInvokeResponses
        {
            get;
            set;
        }

        [DataMember]
        public StateLogAPI stateLog
        {
            get;
            set;
        }

        [DataMember]
        public List<EngineValueAPI> preCommitStateValues
        {
            get;
            set;
        }

        [DataMember]
        public List<EngineValueAPI> stateValues
        {
            get;
            set;
        }

        [DataMember]
        public List<EngineValueAPI> outputs
        {
            get;
            set;
        }

        [DataMember]
        public String statusCode
        {
            get;
            set;
        }

        [DataMember]
        public String runFlowUri
        {
            get;
            set;
        }

        [DataMember]
        public String joinFlowUri
        {
            get;
            set;
        }

        [DataMember]
        public EngineAuthorizationContextAPI authorizationContext
        {
            get;
            set;
        }

        [DataMember]
        public List<NavigationElementReferenceAPI> navigationElementReferences
        {
            get;
            set;
        }
    }
}
