using System;
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
        public String pageComponentId
        {
            get;
            set;
        }

        /// <summary>
        /// A temporary reference to the field on which to apply this filter configuration.
        /// </summary>
        [DataMember]
        public String pageComponentDeveloperName
        {
            get;
            set;
        }

        /// <summary>
        /// This is the type element entry for the column field to do the filtering on.
        /// </summary>
        [DataMember]
        public String columnTypeElementPropertyId
        {
            get;
            set;
        }

        /// <summary>
        /// The criteria for the filter to apply to the column.
        /// </summary>
        [DataMember]
        public String criteriaType
        {
            get;
            set;
        }

        /// <summary>
        /// The value to reference when performing the filter.
        /// </summary>
        [DataMember]
        public PageObjectReferenceAPI filterValue
        {
            get;
            set;
        }

        /// <summary>
        /// This object will not be null if we want to apply a different object data request to the field in question.  This allows us
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