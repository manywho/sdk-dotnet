using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Value;
using ManyWho.Flow.SDK.Draw.Flow;

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
    public class FlowOutAPI
    {
        /// <summary>
        /// The Value in your Flow that contains the unique identifier for the State you wish to flow out to. This is used if you wish to join an already executing Flow from the parent Flow.
        /// </summary>
        [DataMember]
        public ValueElementIdAPI valueElementStateId
        {
            get;
            set;
        }

        /// <summary>
        /// The Value in your Flow that contains a unique identifier for the Flow you with to flow out to. As above, this will always opt to run the latest active/default version of the Flow. However, in this situation, you can dynamically provide the Flow you wish to execute.
        /// </summary>
        [DataMember]
        public ValueElementIdAPI valueElementFlowId
        {
            get;
            set;
        }

        /// <summary>
        /// The composite unique identifier for the Flow you wish to run. The engine will only respect the "id" part of the unique identifier and will always opt to run the latest active/default version of the Flow.
        /// </summary>
        [DataMember]
        public FlowIdAPI flowId
        {
            get;
            set;
        }

        /// <summary>
        /// The Value in your Flow that contains a unique identifier you wish to tag the child Flow State with. The external identifier can be used to retrieve a State from ManyWho.
        /// </summary>
        [DataMember]
        public ValueElementIdAPI valueElementExternalIdentifierId
        {
            get;
            set;
        }
    }
}
