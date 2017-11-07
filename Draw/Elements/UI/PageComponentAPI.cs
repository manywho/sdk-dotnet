using System;
using System.Collections.Generic;
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

namespace ManyWho.Flow.SDK.Draw.Elements.UI
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageComponentAPI
    {
        /// <summary>
        /// The unique identifier for the page component. This property is created by the service.
        /// </summary>
        [DataMember]
        public String id
        {
            get;
            set;
        }
        
        /// <summary>
        /// Indicates if the user is able to edit the information associated with this component. The editable status can be altered by page conditions.
        /// </summary>
        [DataMember]
        public Boolean isEditable
        {
            get;
            set;
        }

        /// <summary>
        /// The reference Value Element that should be used to store the data associated with this page component. For form components, the content type of the bound Value Element determines the type of field.
        /// </summary>
        [DataMember]
        public ValueElementIdAPI valueElementValueBindingReferenceId
        {
            get;
            set;
        }

        /// <summary>
        /// The reference Value Element that should be used to provide data for the component. This is only appropriate for components that support data: e.g. TABLE, COMBOBOX. If a record or set of records are selected from the result set, they are stored in the Value Element referenced by the valueElementValueBindingReferenceId object. In this scenario, the data is available in the State. For async data requests against an external database, use the object data request object.
        /// </summary>
        [DataMember]
        public ValueElementIdAPI valueElementDataBindingReferenceId
        {
            get;
            set;
        }

        /// <summary>
        /// Used to get the data in real-time from the external data source - using this object data request as the configuration of that
        /// request.
        /// </summary>
        [DataMember]
        public ObjectDataRequestConfigAPI objectDataRequest
        {
            get;
            set;
        }

        /// <summary>
        /// Used to get the file data in real-time from the external data source - using the file data request as the configuration of that
        /// request.
        /// </summary>
        [DataMember]
        public FileDataRequestConfigAPI fileDataRequest
        {
            get;
            set;
        }

        /// <summary>
        /// The resource location of the image used in image type components.
        /// </summary>
        [DataMember]
        public String imageUri
        {
            get;
            set;
        }
        
        /// <summary>
        /// The unique identifier for the page container this component should be rendered in. During the development of your page layouts, use the pageContainerDeveloperName property rather than the identifier - the modeling engine will match the developer names to identifiers for you.
        /// </summary>
        [DataMember]
        public String pageContainerId
        {
            get;
            set;
        }

        /// <summary>
        /// The unique developer name for the page container this component should be rendered in.
        /// </summary>
        [DataMember]
        public String pageContainerDeveloperName
        {
            get;
            set;
        }

        /// <summary>
        /// We have a developer name field solely for external services - so they can match fields appropriately with respect
        /// to form layouts for types.
        /// </summary>
        [DataMember]
        public String developerName
        {
            get;
            set;
        }

        /// <summary>
        /// The type of component to render. The current player implementations support the component types listed in the enumeration. However, developers can define their own component types (but will need to make sure these are then supported in the player).
        /// </summary>
        [DataMember]
        public String componentType
        {
            get;
            set;
        }

        /// <summary>
        /// The content that should be used for this component. This is typically snippets of html5, but can be any mark-up.
        /// </summary>
        [DataMember]
        public String content
        {
            get;
            set;
        }

        /// <summary>
        /// The label for this particular component.
        /// </summary>
        [DataMember]
        public String label
        {
            get;
            set;
        }
        
        /// <summary>
        /// The list of columns to show when rendering the data from an objectDataRequest or valueElementDataBindingReferenceId lookup.
        /// </summary>
        [DataMember]
        public List<PageComponentColumnAPI> columns
        {
            get;
            set;
        }

        /// <summary>
        /// The size of content that is typically associated with this component. For form controls, this is the typical number of characters to expect the user to enter into the component.
        /// </summary>
        [DataMember]
        public Int32 size
        {
            get;
            set;
        }

        /// <summary>
        /// The maximum size of content that can be associated with this component. For form controls, this is the maximum number of characters to allow the user to enter into the component.
        /// </summary>
        [DataMember]
        public Int32 maxSize
        {
            get;
            set;
        }

        /// <summary>
        /// The height of this component. For form controls, this is the number of rows of characters to show. For image components, this is the height in pixels of the image.
        /// </summary>
        [DataMember]
        public Int32 height
        {
            get;
            set;
        }

        /// <summary>
        /// The width of this component. For form controls, this is the number of columns of characters to show. For image components, this is the width in pixels of the image.
        /// </summary>
        [DataMember]
        public Int32 width
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the user is required to complete the information associated with this component. The required status can be altered by page conditions.
        /// </summary>
        [DataMember]
        public Boolean isRequired
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the user can select more than one data object associated with this component. If the component supports multiselection, then the bound Value Element must have a content type of ContentList.
        /// </summary>
        [DataMember]
        public Boolean isMultiSelect
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the user is able to search using this component.
        /// </summary>
        [DataMember]
        public Boolean isSearchable
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies information that can be given to the user to help them complete the information associated with this component. For form controls, this is typically text that's displayed inside the input that disappears when the user focuses on the component.
        /// </summary>
        [DataMember]
        public String hintValue
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies information that can be given to the user to help them complete the information associated with this component. For form controls, this is typically shown to the user when they hover over the component or click a help link beside the component.
        /// </summary>
        [DataMember]
        public String helpInfo
        {
            get;
            set;
        }

        /// <summary>
        /// The order in which the page component should be rendered relative to its peers. The lowest number is rendered first.
        /// </summary>
        [DataMember]
        public Int32 order
        {
            get;
            set;
        }
        
        /// <summary>
        /// Arbitrary key value pairs that may help the component render/execute. Use attributes to extend our PageComponent metadata with implementation specific settings.
        /// </summary>
        [DataMember]
        public Dictionary<String, String> attributes
        {
            get;
            set;
        }

        /// <summary>
        /// The list of page tags that allow additional metadata to be applied to the page component. Conceptually tags can be used to mimic html css but can also be used to provided data to enrich functionality of the page component.
        /// </summary>
        [DataMember]
        public List<PageTagAPI> tags
        {
            get;
            set;
        }
    }
}
