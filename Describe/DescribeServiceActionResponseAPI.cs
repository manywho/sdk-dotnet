using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.Elements.UI;

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

namespace ManyWho.Flow.SDK.Describe
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class DescribeServiceActionResponseAPI
    {
        /// <summary>
        /// The part of the Uri that will allow us to call this action as part of the service.  For example,
        /// if you specify "myaction", the full Uri for the service would be "https://myservice.com/myservice/myaction".
        /// </summary>
        [DataMember]
        public String uriPart
        {
            get;
            set;
        }

        /// <summary>
        /// The label for this action.
        /// </summary>
        [DataMember]
        public String developerName
        {
            get;
            set;
        }

        /// <summary>
        /// The developer summary for the service operation.
        /// </summary>
        [DataMember]
        public String developerSummary
        {
            get;
            set;
        }

        /// <summary>
        /// The optional form to provide a more compelling UI for the service inputs.
        /// </summary>
        [DataMember]
        public PageResponseAPI pageResponse
        {
            get;
            set;
        }

        /// <summary>
        /// For UI actions, this property provides the bindable outcomes so the author can wire buttons to steps in the flow.
        /// </summary>
        [DataMember]
        public List<DescribeUIServiceActionOutcomeAPI> serviceActionOutcomes
        {
            get;
            set;
        }

        /// <summary>
        /// The service inputs that need to be provided.
        /// </summary>
        [DataMember]
        public List<DescribeValueAPI> serviceInputs
        {
            get;
            set;
        }

        /// <summary>
        /// The service outputs that will be provided back.
        /// </summary>
        [DataMember]
        public List<DescribeValueAPI> serviceOutputs
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if this message action is for views rather than logic.
        /// </summary>
        public Boolean isViewMessageAction
        {
            get;
            set;
        }
    }
}