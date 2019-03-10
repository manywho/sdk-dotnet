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

namespace ManyWho.Flow.SDK.Draw.Elements.Map
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class MessageOutputAPI : OutputValueAPI
    {
        /// <summary>
        /// The developer name for the output defined by the Service definition of this message action. This name will be used by the Service Implementation to match which value is being sent back.
        /// </summary>
        [DataMember]
        public string developerName
        {
            get;
            set;
        }

        /// <summary>
        /// The content type for this output as provided by the Service.
        /// </summary>
        [DataMember]
        public string contentType
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
        /// The order in which this output should appear to Flow builders.
        /// </summary>
        [DataMember]
        public int order
        {
            get;
            set;
        }

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
    }
}