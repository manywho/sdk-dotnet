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
    public class OutcomeAPI
    {
        /// <summary>
        /// The unique identifier for the outcome. This property is created by the service.
        /// </summary>
        [DataMember]
        public String id
        {
            get;
            set;
        }

        /// <summary>
        /// The developer name to help identify this outcome in tooling and APIs.
        /// </summary>
        [DataMember]
        public String developerName
        {
            get;
            set;
        }

        /// <summary>
        /// The developer summary the author provided to give more information about the Map Element.
        /// </summary>
        [DataMember]
        public String developerSummary
        {
            get;
            set;
        }

        /// <summary>
        /// The label that should appear with the outcome. For UI situations, this is typically the text that will appear on the button.
        /// </summary>
        [DataMember]
        public String label
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the next Map Element in the Flow that should be executed if this outcome is selected.
        /// </summary>
        [DataMember]
        public String nextMapElementId
        {
            get;
            set;
        }

        /// <summary>
        /// The page action type can be used to provide additional metadata to help player developers provide standard styling and positions for outcomes. The enumeration provided is partly implemented by the existing players, though the values can be extended as needed.
        /// </summary>
        [DataMember]
        public String pageActionType
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if this is bulk action. This is commonly used when presenting lists of object data to tell the player if the outcome should be displayed inline with each object entry or if it should be displayed at the top of the component as a "bulk" action.
        /// </summary>
        [DataMember]
        public Boolean isBulkAction
        {
            get;
            set;
        }

        /// <summary>
        /// The page action binding type is bound to functionality in the flow and instructs the engine what to do with any data provided in the page components.
        /// </summary>
        [DataMember]
        public String pageActionBindingType
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the page container or component this outcome should be bound to. If you bind an outcome to a container or component, it can also indicate additional functionality: e.g. isBulkAction, etc. It also helps player designers lay out the page.
        /// </summary>
        [DataMember]
        public String pageObjectBindingId
        {
            get;
            set;
        }

        /// <summary>
        /// The order in which the outcomes should be rendered relative to its peers. The lowest number is rendered first.
        /// </summary>
        [DataMember]
        public Int32 order
        {
            get;
            set;
        }

        /// <summary>
        /// The comparison object defines the rules that should be evaluated for this outcome to be selected by the system. As a result, the comparison object should only be used for system level outcomes.
        /// </summary>
        [DataMember]
        public ComparisonAPI comparison
        {
            get;
            set;
        }

        /// <summary>
        /// The comparison object defines the rules that should be evaluated for this outcome to be selected by the system. As a result, the comparison object should only be used for system level outcomes.
        /// </summary>
        [DataMember]
        public FlowOutAPI flowOut
        {
            get;
            set;
        }

        [DataMember]
        public List<ControlPointAPI> controlPoints
        {
            get;
            set;
        }

        [DataMember]
        public string nextMapElementDeveloperName
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