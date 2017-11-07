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

namespace ManyWho.Flow.SDK.Run.Elements.UI
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageComponentResponseAPI
    {
        /// <summary>
        /// The developer name for the page container this component should be placed into. When rendering a UI, it's best to reference the pageContainerId as this developer name is not guaranteed to be unique.
        /// </summary>
        [DataMember]
        public String pageContainerDeveloperName
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the page container this component should be placed into. When rendering a UI, this is the best reference to use as the developer names are not guaranteed to be unique.
        /// </summary>
        [DataMember]
        public String pageContainerId
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifer for this page component.
        /// </summary>
        [DataMember]
        public String id
        {
            get;
            set;
        }

        /// <summary>
        /// The name the author has given for this component.
        /// </summary>
        [DataMember]
        public String developerName
        {
            get;
            set;
        }

        /// <summary>
        /// The type of component that should be used. The platform currently supports the standard components such as "INPUT", "SELECT", etc as would be familiar with HTML UI. If you want to provide additional UI componentry, we recommend using "tags" to inform the player that you want to adapt the component based on the data in the tag. For example, you may want to change a particular number input to a "slider" or you might bind this page component to a widget - again, based on the data in the tag.
        /// </summary>
        [DataMember]
        public String componentType
        {
            get;
            set;
        }

        /// <summary>
        /// The type of content the component holds.
        /// </summary>
        [DataMember]
        public String contentType
        {
            get;
            set;
        }

        /// <summary>
        /// The label for the component. This is often the label for a form field.
        /// </summary>
        [DataMember]
        public String label
        {
            get;
            set;
        }

        /// <summary>
        /// The columns associated with this page component. This property is only used for "TABLE"/"SELECT" components and details out the columns that should be displayed to the user. This property is not currently fully documented until we release the page composition tool.
        /// </summary>
        [DataMember]
        public List<PageComponentColumnResponseAPI> columns
        {
            get;
            set;
        }

        /// <summary>
        /// The size of the component. For "INPUT" components, this is typically the number of characters wide to display the input box.
        /// </summary>
        [DataMember]
        public Int32 size
        {
            get;
            set;
        }

        /// <summary>
        /// The maximum size of characters the component can hold. For "INPUT" and "TEXTAREA" components, this is the amount of content these inputs can hold.
        /// </summary>
        [DataMember]
        public Int32 maxSize
        {
            get;
            set;
        }

        /// <summary>
        /// The height of the component. For "TEXTAREA" components, this is typically the number of characters high to display the text box. For "IMAGE" components, this is the height in pixels of the image.
        /// </summary>
        [DataMember]
        public Int32 height
        {
            get;
            set;
        }

        /// <summary>
        /// The width of the component. For "TEXTAREA" components, this is typically the number of characters wide to display the text box. For "IMAGE" components, this is the width in pixels of the image.
        /// </summary>
        [DataMember]
        public Int32 width
        {
            get;
            set;
        }

        /// <summary>
        /// The information that should be shown to the user to help them understand what they need to enter. For "INPUT" components, this if often the text you see in the input box (e.g. Enter Name) that disappears once you enter something into the input.
        /// </summary>
        [DataMember]
        public String hintValue
        {
            get;
            set;
        }

        /// <summary>
        /// The help information to assist the user in completing this page component. The help information is often something the user sees if they click on a "help" button beside the component or hover over a "help" icon.
        /// </summary>
        [DataMember]
        public String helpInfo
        {
            get;
            set;
        }

        /// <summary>
        /// The order in which this component should be placed with respect to other components in the same page container.
        /// </summary>
        [DataMember]
        public Int32 order
        {
            get;
            set;
        }

        /// <summary>
        /// This property indicates if the component supports selection of more than one value. This is only applicable for "TABLE"/"SELECT" components.
        /// </summary>
        [DataMember]
        public Boolean isMultiSelect
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isSearchable
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if changes to this component should result in a "SYNC" invoke type with the service. If the component has events, it's likely that the page state needs to change based on business rules. If the component does not have events, there is no need to update the service of changes made to the value of the component.
        /// </summary>
        [DataMember]
        public Boolean hasEvents
        {
            get;
            set;
        }

        [DataMember]
        public Dictionary<String, String> attributes
        {
            get;
            set;
        }
    }
}