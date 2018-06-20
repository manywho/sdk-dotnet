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

namespace ManyWho.Flow.SDK.Run.Elements.Map
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class OutcomeResponseAPI : OutcomeAvailableAPI
    {
        /// <summary>
        /// The page action binding type as specified by the builder user.
        /// </summary>
        [DataMember]
        public string pageActionBindingType
        {
            get;
            set;
        }

        /// <summary>
        /// The page action type as specified by the builder user. This helps inform the UI of the "type" of outcome - e.g. selecting it will perform a "DELETE" operation or a "SAVE" operation.
        /// </summary>
        [DataMember]
        public string pageActionType
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the outcome is a "bulk" action. If an outcome is bound to a component such as a TABLE, this indicates that the outcome applies to all records, not individual records.
        /// </summary>
        [DataMember]
        public bool isBulkAction
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the page object (PageComponent or PageContainer) that this outcome should be bound to.
        /// </summary>
        [DataMember]
        public string pageObjectBindingId
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if this outcome should invoke the "out" API to initialize and invoke a child Flow or join child Flow.
        /// </summary>
        [DataMember]
        public bool isOut
        {
            get;
            set;
        }

        [DataMember]
        public Dictionary<string, string> attributes
        {
            get;
            set;
        }
    }
}