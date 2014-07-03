using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Flow;
using ManyWho.Flow.SDK.Run.Elements;
using ManyWho.Flow.SDK.Run.Elements.Config;

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
    public class EngineInitializationRequestAPI
    {
        [DataMember]
        public FlowIdAPI flowId
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
        public String externalIdentifier
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
        public List<EngineValueAPI> inputs
        {
            get;
            set;
        }

        [DataMember]
        public String playerUrl
        {
            get;
            set;
        }

        [DataMember]
        public String joinPlayerUrl
        {
            get;
            set;
        }

        [DataMember]
        public String mode
        {
            get;
            set;
        }

        [DataMember]
        public String reportingMode
        {
            get;
            set;
        }
    }
}
