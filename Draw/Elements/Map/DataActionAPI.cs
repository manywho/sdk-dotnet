using System;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Type;
using ManyWho.Flow.SDK.Draw.Elements.Value;

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
    public class DataActionAPI
    {
        /// <summary>
        /// The developer name to help identify this data action in tooling and APIs.
        /// </summary>
        [DataMember]
        public String developerName
        {
            get;
            set;
        }

        /// <summary>
        /// The operation (<code>SAVE</code>, <code>LOAD</code> or <code>DELETE</code>) that should be performed on the
        /// objects provided in this data action.
        /// </summary>
        [DataMember]
        public String crudOperationType
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the data should saved using tracked changes in the data. Smart save must be supported in the
        /// underlying service as the platform will only send changed data back to the service rather than the complete
        /// object or list.
        /// </summary>
        [DataMember]
        public Boolean isSmartSave
        {
            get;
            set;
        }

        /// <summary>
        /// The order in which the data action should be performed in relation to other data actions. The order must be
        /// greater than or equal to zero. If data actions have the same order, they will be performed in parallel to
        /// improve flow performance.
        /// </summary>
        [DataMember]
        public Int32 order
        {
            get;
            set;
        }

        /// <summary>
        /// Whether the data action is disabled or not
        /// </summary>
        [DataMember]
        public bool disabled
        {
            get;
            set;
        }

        /// <summary>
        /// The reference to the value that should be used to send data to the service. The value must be a
        /// <code>ContentObject</code> or <code>ContentList</code> and must have a valid binding in the selected service.
        /// </summary>
        /// <remarks>
        /// This property is only needed for <code>SAVE</code> or <code>DELETE</code> operations or for <code>LOAD</code>
        /// operations where <code>filterByProvidedObjects</code> is <code>true</code>.
        /// </remarks>
        [DataMember]
        public ValueElementIdAPI valueElementToReferenceId
        {
            get;
            set;
        }

        /// <summary>
        /// The reference to the value that should be used to apply any data back from the service. The value must be a
        /// <code>ContentObject</code> or <code>ContentList</code> and must have a valid binding in the selected service.
        /// </summary>
        /// <remarks>
        /// This property is only needed for <code>SAVE</code> or <code>LOAD</code> operations
        /// </remarks>
        [DataMember]
        public ValueElementIdAPI valueElementToApplyId
        {
            get;
            set;
        }

        /// <summary>
        /// The configuration of the data operation being performed
        /// </summary>
        [DataMember]
        public ObjectDataRequestConfigAPI objectDataRequest
        {
            get;
            set;
        }
    }
}
