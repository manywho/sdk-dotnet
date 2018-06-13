using System;
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

namespace ManyWho.Flow.SDK.Run.Elements.Config
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ValueFaultAPI
    {
        /// <summary>
        /// The unique identifier of the Value that caused the fault in the Service. This allows ManyWho to match this fault with any Pages that display it to a user.
        /// </summary>
        [DataMember]
        public string valueElementToReferenceId
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier of the Type Property that cause the fault in the Service. This is only applicable for ContentObject and ContentList Values.
        /// </summary>
        [DataMember]
        public string valueElementTypeElementPropertyToReferenceId
        {
            get;
            set;
        }

        /// <summary>
        /// An informative code from the Service to indicate the type of fault that occurred.
        /// </summary>
        [DataMember]
        public string faultCode
        {
            get;
            set;
        }

        /// <summary>
        /// A fault message that will help users understand how to fix the fault in their provided value.
        /// </summary>
        [DataMember]
        public string faultMessage
        {
            get;
            set;
        }
    }
}
