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
        /// <remarks>
        /// This value should not be included when creating new outcomes.
        /// </remarks>
        [DataMember]
        public string id
        {
            get;
            set;
        }

        /// <summary>
        /// The developer name to help identify this outcome in tooling and APIs.
        /// </summary>
        [DataMember]
        public string developerName
        {
            get;
            set;
        }

        /// <summary>
        /// The developer summary the author provided to give more information about the outcome.
        /// </summary>
        [DataMember]
        public string developerSummary
        {
            get;
            set;
        }

        /// <summary>
        /// The label that should appear with the outcome. For UI situations, this is typically the text that will
        /// appear on the button.
        /// </summary>
        [DataMember]
        public string label
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the next map element in the flow that should be executed if this outcome is
        /// selected.
        /// </summary>
        /// <remarks>
        /// If a <code>flowOut</code> key is configured, this property is not required as the running user(s) will leave
        /// the current flow and be sent into the flow configured in the <code>flowOut</code>.
        /// </remarks>
        [DataMember]
        public string nextMapElementId
        {
            get;
            set;
        }

        /// <summary>
        /// Determines if the data collected in this map element should be saved, and the type of validation that should
        /// be applied when saving.
        /// </summary>
        [DataMember]
        public string pageActionType
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates that this outcome should be treated as a “bulk” operation.
        /// </summary>
        /// <remarks>
        /// This is commonly used when presenting lists of object data to tell the player if the outcome should be
        /// displayed inline with each object entry or if it should be displayed at the top of the component as a "bulk"
        /// action.
        /// </remarks>
        [DataMember]
        public bool isBulkAction
        {
            get;
            set;
        }

        /// <summary>
        /// An arbitrary string value that indicates the type of button the outcome represents. This indicates to UX
        /// designers how they should render the button to running users.
        /// </summary>
        /// <remarks>
        /// For example, if this key is set to <code>DELETE</code>, the UX designer might decide to give the outcome
        /// button a red background and an "x" icon.
        /// </remarks>
        [DataMember]
        public string pageActionBindingType
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the page container or component this outcome should be bound to. If you bind an
        /// outcome to a container or component, it can also indicate additional functionality: e.g.
        /// <code>isBulkAction</code>, etc. It also helps player designers layout the page.
        /// </summary>
        [DataMember]
        public string pageObjectBindingId
        {
            get;
            set;
        }

        /// <summary>
        /// The order in which the outcomes should be rendered relative to its peers. The lowest number is rendered first.
        /// </summary>
        [DataMember]
        public int order
        {
            get;
            set;
        }

        /// <summary>
        /// The comparison object defines the rules that should be evaluated for this outcome to be selected by the
        /// system. As a result, the comparison object should only be used for system level outcomes.
        /// </summary>
        [DataMember]
        public ComparisonAPI comparison
        {
            get;
            set;
        }

        /// <summary>
        /// The details of the flow that this outcome should link to if the user clicks on the outcome. The flow out
        /// configuration can only be used with step and page elements.
        /// </summary>
        [DataMember]
        public FlowOutAPI flowOut
        {
            get;
            set;
        }
        
        /// <summary>
        /// The array of control points (or “kinks”) in the outcome arrow as it appears in the flow diagram. If there
        /// are no control points, it is assumed the arrow for the outcome points directly from this map element to the
        /// next map element.
        /// </summary>
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