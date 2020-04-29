using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Type;

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
    public class PageOperationFilterAPI
    {
        /// <summary>
        /// This is the reference field to apply the filter information contained in this action.
        /// </summary>
        [DataMember]
        public string pageComponentId
        {
            get;
            set;
        }

        /// <summary>
        /// A temporary reference to the field on which to apply this filter configuration.
        /// </summary>
        [DataMember]
        public string pageComponentDeveloperName
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the column in the bound component data to filter by. This property should only be used when filtering components that are bound to lists stored in the engine state. For filtering asynchronous data, use the objectDataRequest property.
        /// </summary>
        [DataMember]
        public string columnTypeElementPropertyId
        {
            get;
            set;
        }

        /// <summary>
        /// The criteria to filter the list data by.
        /// </summary>
        [DataMember]
        public string criteriaType
        {
            get;
            set;
        }

        /// <summary>
        /// The reference to the object that contains the value to filter the list data by.
        /// </summary>
        [DataMember]
        public PageObjectReferenceAPI filterValue
        {
            get;
            set;
        }

        /// <summary>
        /// The object data request object to apply to the page component. This will be provided back to the player to execute asynchronously. This allows us
        /// to do more complex data querying than that provided by the "in-UI" Filter object above.  You cannot use the filter above
        /// with the object data request - it's basically either or.
        /// </summary>
        [DataMember]
        public ObjectDataRequestConfigAPI objectDataRequest
        {
            get;
            set;
        }
    }
}