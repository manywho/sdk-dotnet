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

namespace ManyWho.Flow.SDK.Draw.Elements.Map
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class VoteAPI
    {
        /// <summary>
        /// The type of Vote this metadata represents. The <code>voteType</code> is determined by the service.
        /// </summary>
        /// <remarks>
        /// The values for this key are arbitrary, however, if a service supports voting, we request that developers
        /// support two fundamental Voting approaches:
        /// 
        /// <ul>
        /// <li><strong>COUNT:</strong> The vote should be based on a fixed number of running users that click on the
        /// outcome.</li>
        /// <li><strong>PERCENT:</strong> The vote should be based on the percentage of running users that click on the
        /// outcome. The percentage is calculated based on the authorization context of the map element at the time of
        /// execution.</li>
        /// </ul>
        /// </remarks>
        [DataMember]
        public string voteType
        {
            get;
            set;
        }

        /// <summary>
        /// The minimum number of users that need to click on an outcome before the flow will proceed to the next step.
        /// </summary>
        [DataMember]
        public int minimumCount
        {
            get;
            set;
        }

        /// <summary>
        /// The minimum percentage of users that need to click on an outcome before the flow will proceed to the next
        /// step. The percentage is determined based on the authorization context of either the flow or the group
        /// swimlane (if the map element is contained in a swimlane).
        /// </summary>
        [DataMember]
        public int minimumPercent
        {
            get;
            set;
        }

        /// <summary>
        /// Arbitrary key value pairs that may help the service execute the vote. Use attributes to extend the vote
        /// metadata with implementation specific settings.
        /// </summary>
        [DataMember]
        public Dictionary<string, string> attributes
        {
            get;
            set;
        }
    }
}
