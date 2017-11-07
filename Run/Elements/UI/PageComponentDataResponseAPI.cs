using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.Elements.Type;

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

namespace ManyWho.Flow.SDK.Run.Elements.UI
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageComponentDataResponseAPI
    {
        /// <summary>
        /// The unique identifier for the page component that this data pertains to.
        /// </summary>
        [DataMember]
        public String pageComponentId
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the page component should be enabled.
        /// </summary>
        [DataMember]
        public Boolean isEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the page component should be editable.
        /// </summary>
        [DataMember]
        public Boolean isEditable
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the page component should be required.
        /// </summary>
        [DataMember]
        public Boolean isRequired
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the page component should be visible.
        /// </summary>
        [DataMember]
        public Boolean isVisible
        {
            get;
            set;
        }

        /// <summary>
        /// The up-to-date object data for the component. For page components that use asynchronous object data requests, this list contains the selected objects. If not, the object data is flagged with "isSelected" for all objects in the list that should be rendered to the user as selected. This object will be further documented when we release the page composition tool.
        /// </summary>
        [DataMember]
        public List<ObjectAPI> objectData
        {
            get;
            set;
        }

        /// <summary>
        /// The request object that should be dispatched to the data service to get the list of data that needs to be populated in the component. The object data request is provided so the player can determine when the request for the data should be dispatched (e.g. only when enabled). In addition, the player can modify this request object to include search terms and paging to ensure the user is getting the necessary data. This object will be further documented when we release the page composition tool.
        /// </summary>
        [DataMember]
        public ObjectDataRequestAPI objectDataRequest
        {
            get;
            set;
        }

        [DataMember]
        public FileDataRequestAPI fileDataRequest
        {
            get;
            set;
        }

        /// <summary>
        /// The value of the page component. For "INPUT" and "TEXTAREA" components, this is typically the value the user entered.
        /// </summary>
        [DataMember]
        public String contentValue
        {
            get;
            set;
        }

        /// <summary>
        /// Any formatted content that may be associated with this component. For "PRESENTATION" components, this is the content that should be displayed on the page.
        /// </summary>
        [DataMember]
        public String content
        {
            get;
            set;
        }

        [DataMember]
        public String imageUri
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the value provided in the field is valid. The validation is only performed when the user selects an outcome. Validation is not done on values as the result of an invokeType of "SYNC".
        /// </summary>
        [DataMember]
        public Boolean isValid
        {
            get;
            set;
        }

        /// <summary>
        /// Any message from the system that explains why the value is not valid. This message can result from a straight page component validation or as the result of the value not being accepted by a subsequent element in the flow (in which case the author of the flow indicated the user should be taken back to this screen to correct the issue).
        /// </summary>
        [DataMember]
        public String validationMessage
        {
            get;
            set;
        }

        /// <summary>
        /// The page tag provides additional metadata that the author of the flow has defined for this component. Tags are a very powerful way of providing additional information to player developers to ensure the app is providing exactly the user experience you expect. This object will be further documented when we release the page composition tool.
        /// </summary>
        [DataMember]
        public List<EngineValueAPI> tags
        {
            get;
            set;
        }
    }
}
