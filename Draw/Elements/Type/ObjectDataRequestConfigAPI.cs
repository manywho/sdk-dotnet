using System;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Content;

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

namespace ManyWho.Flow.SDK.Draw.Elements.Type
{
    /// <summary>
    /// This object stores the configuration information we need to make object data requests as part of a map element request or
    /// as part of a form field.
    /// </summary>
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ObjectDataRequestConfigAPI
    {
        /// <summary>
        /// The unique identifier for the binding that should be used on the provided Type.
        /// </summary>
        [DataMember]
        public String typeElementBindingId
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the Type that will define the structure of the data returned by this request.
        /// </summary>
        [DataMember]
        public String typeElementId
        {
            get;
            set;
        }

        /// <summary>
        /// The filter that should be applied to the data at runtime. The list filter can be altered by events on the page. The list filter object can also be used by the player to support additional component filtering and logic such as paging. The properties of the filter can therefore be altered at runtime to optimize the user experience.
        /// </summary>
        [DataMember]
        public ListFilterConfigAPI listFilter
        {
            get;
            set;
        }

        /// <summary>
        /// Any additional attributes to help with the object data request.
        /// </summary>
        [DataMember]
        public CommandAPI command
        {
            get;
            set;
        }

        [DataMember]
        public string typeElementDeveloperName
        {
            get;
            set;
        }
    }
}
