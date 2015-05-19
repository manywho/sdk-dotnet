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

namespace ManyWho.Flow.SDK.Draw.Elements.Config
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ServiceValueRequestAPI
    {
        [DataMember]
        public string developerName
        {
            get;
            set;
        }

        [DataMember]
        public ValueElementIdAPI valueElementToReferenceId
        {
            get;
            set;
        }

        /// <summary>
        /// This is a temporary property so we have the name of the shared element and type element entry tagged against the value (useful in listings)
        /// </summary>
        [DataMember]
        public string valueElementToReferenceDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public string contentType
        {
            get;
            set;
        }

        [DataMember]
        public int order
        {
            get;
            set;
        }
    }
}