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

namespace ManyWho.Flow.SDK.Draw.Elements.UI
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageComponentColumnAPI
    {
        /// <summary>
        /// The unique identifier for the property in that should be displayed in this column. This pertains to the Type for the bound data or the object data request - not the underlying value binding.
        /// </summary>
        [DataMember]
        public string typeElementPropertyId
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates that this specific column is bound to the underlying value binding. This can only be true if the content type of this property is the same as the content type of the bound value. It is also not valid for this to be true for multiselect data components.
        /// </summary>
        [DataMember]
        public bool isBound
        {
            get;
            set;
        }
        
        /// <summary>
        /// The unique identifier for the property in the value binding that should be used to store the selected value. This pertains to the Type for the value binding, not the Type for the bound data or the object data request.
        /// </summary>
        [DataMember]
        public string boundTypeElementPropertyId
        {
            get;
            set;
        }

        /// <summary>
        /// The label that should be used for this column. Often the label is displayed as the column header, but for mobile applications, this may be used inline with the object entry data.
        /// </summary>
        [DataMember]
        public string label
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates that this value should be shown in the UI to the end user.
        /// </summary>
        [DataMember]
        public bool isDisplayValue
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates that this value is editable inline in this component.
        /// </summary>
        [DataMember]
        public bool isEditable
        {
            get;
            set;
        }

        /// <summary>
        /// The order in which the page component column should be rendered relative to its peers. The lowest number is rendered first.
        /// </summary>
        [DataMember]
        public int order
        {
            get;
            set;
        }

        [DataMember]
        public string typeElementPropertyToDisplayId
        {
            get;
            set;
        }

        [DataMember]
        public string componentType
        {
            get;
            set;
        }

        [DataMember]
        public string typeElementPropertyDeveloperName
        {
            get;
            set;
        }
    }
}
