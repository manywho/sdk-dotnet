using System;
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

namespace ManyWho.Flow.SDK.Draw.Flow
{
    /// <summary>
    /// A composite unique identifier assigned by the platform, which should not be included for new flows.
    /// </summary>
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class FlowIdAPI
    {
        public FlowIdAPI()
        {
        }

        public FlowIdAPI(string id) 
        {
            this.id = id;
        }

        public FlowIdAPI(string id, string versionId) : this(id)
        {
            this.versionId = versionId;
        }

        public FlowIdAPI(Guid id)
        {
            this.id = id.ToString();
        }

        public FlowIdAPI(Guid id, Guid versionId) : this(id)
        {
            this.versionId = versionId.ToString();
        }

        /// <summary>
        /// The unique identifier for the flow. This identifier does not change for the lifetime of the flow and is generated when the flow is first created.
        /// </summary>
        [DataMember]
        public string id
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for a specific version of a flow. This identifier changes any time a change is made to the flow - in structure or content.
        /// </summary>
        [DataMember]
        public string versionId
        {
            get;
            set;
        }
    }
}