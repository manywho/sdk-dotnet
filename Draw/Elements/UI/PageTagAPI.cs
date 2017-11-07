using System;
using System.Runtime.Serialization;
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
    public class PageTagAPI
    {
        /// <summary>
        /// The reference to the Value that holds the data to be provided in the tag. This may be a specific CSS reference or a full object containing configuration data needed to the UI.
        /// </summary>
        [DataMember]
        public ValueElementIdAPI valueElementToReferenceId
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the Tag that this tag is associated. This Tag will be used to provide the Tag name at runtime and also ensure Tag content and object type references are maintained.
        /// </summary>
        [DataMember]
        public String tagElementId
        {
            get;
            set;
        }
    }
}
