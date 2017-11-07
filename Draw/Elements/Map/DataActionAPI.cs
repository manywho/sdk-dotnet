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
        /// The CRUD (create, read, update, delete - or in ManyWho - SAVE, LOAD, DELETE) operation that should be performed on the objects provided in this data action.
        /// </summary>
        [DataMember]
        public String crudOperationType
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isSmartSave
        {
            get;
            set;
        }

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
        /// The reference to the Value that should be used to send data to the Service. The Value must be a ContentObject or ContentList and must have a valid binding in the selected Service.
        /// </summary>
        [DataMember]
        public ValueElementIdAPI valueElementToReferenceId
        {
            get;
            set;
        }

        /// <summary>
        /// The reference to the Value that should be used to apply any data back from the Service. The Value must be a ContentObject or ContentList and must have a valid binding in the selected Service.
        /// </summary>
        [DataMember]
        public ValueElementIdAPI valueElementToApplyId
        {
            get;
            set;
        }

        /// <summary>
        /// The object data request properties object holds the specific configuration information that the Service can use to optimize requests from ManyWho.
        /// </summary>
        [DataMember]
        public ObjectDataRequestConfigAPI objectDataRequest
        {
            get;
            set;
        }
    }
}
