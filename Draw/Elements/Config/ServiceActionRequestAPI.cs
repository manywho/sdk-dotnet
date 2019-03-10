using System;
using System.Collections.Generic;
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

namespace ManyWho.Flow.SDK.Draw.Elements.Config
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ServiceActionRequestAPI
    {
        /// <summary>
        /// The uri part that will be used in addition to the base uri provided for the Service. This needs to match up with the uriPart of the actions sent back from the Service description.
        /// </summary>
        [DataMember]
        public string uriPart
        {
            get;
            set;
        }

        /// <summary>
        /// The developer name for the service action. This does not need to match with the service description as the matching to action is done based on uri part above.
        /// </summary>
        [DataMember]
        public string developerName
        {
            get;
            set;
        }

        /// <summary>
        /// The developer summary the author provided to give more information about the service action.
        /// </summary>
        [DataMember]
        public string developerSummary
        {
            get;
            set;
        }

        /// <summary>
        /// This property is not yet supported. Indicates if this particular service action will return a View as opposed to being a system-to-system API reference. If this is a View message action, then it can be used in 'Remote Page' map elements.
        /// </summary>
        [DataMember]
        public bool isViewMessageAction
        {
            get;
            set;
        }

        /// <summary>
        /// This property is not yet supported. Provides the outcomes that the View exposes for the Author to use as outcomes in their Flow.
        /// </summary>
        [DataMember]
        public List<ServiceActionOutcomeAPI> serviceActionOutcomes
        {
            get;
            set;
        }

        /// <summary>
        /// The list of input values that are available for this particular action. The only supported properties on the service value request object are: id, developerName and ContentType as the Value references are defined by the actions in each 'Message' map element.
        /// </summary>
        [DataMember]
        public List<ServiceValueRequestAPI> serviceInputs
        {
            get;
            set;
        }

        /// <summary>
        /// The list of output values that are available for this particular action. The only supported properties on the service value request object are: id, developerName and ContentType as the Value references are defined by the actions in each 'Message' map element.
        /// </summary>
        [DataMember]
        public List<ServiceValueRequestAPI> serviceOutputs
        {
            get;
            set;
        }
    }
}