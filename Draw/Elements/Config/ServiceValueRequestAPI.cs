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
        /// <summary>
        /// The developer name for the service value. This needs to match up with the developerName of the configuration value sent back from the Service description.
        /// </summary>
        [DataMember]
        public string developerName
        {
            get;
            set;
        }

        /// <summary>
        /// The compound identifier and command for the reference Value to be used to provide the actual value for the configuration value. The Value must be the same ContentType and Type definition (if an Object or List) as that provided by the Service description.
        /// </summary>
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
        public string typeElementDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public string typeElementId
        {
            get;
            set;
        }

        /// <summary>
        /// The type of content the component holds.
        /// </summary>
        [DataMember]
        public string contentType
        {
            get;
            set;
        }

        /// <summary>
        /// The order in which this Value should appear to builder users.
        /// </summary>
        [DataMember]
        public int order
        {
            get;
            set;
        }
    }
}