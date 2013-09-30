using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// <summary>
    /// This acts as the column descriptor for rendering the table content stored in the content property (as part of the parent
    /// field definition).
    /// </summary>
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageComponentColumnResponseAPI
    {
        /// <summary>
        /// This is the developer name of the type element entry.
        /// </summary>
        [DataMember]
        public String developerName
        {
            get;
            set;
        }

        [DataMember]
        public String typeElementPropertyId
        {
            get;
            set;
        }

        [DataMember]
        public String label
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isDisplayValue
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
    }
}
