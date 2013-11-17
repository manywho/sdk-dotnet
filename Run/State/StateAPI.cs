using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Flow;
using ManyWho.Flow.SDK.Run;

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
    [Serializable]
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
        public FlowIdAPI currentFlowId
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
        public String runningUserId
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isCommitted
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isCompleted
        {
            get;
            set;
        }

        [DataMember]
        public Boolean logState
        {
            get;
            set;
        }
    }
}
