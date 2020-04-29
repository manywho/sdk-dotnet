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

namespace ManyWho.Flow.SDK.Run.Elements.Map
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class MapElementInvokeRequestAPI
    {
        /// <summary>
        /// The unique identifier for the outcome the user is taking action on. The outcomes are provided in the MapElementInvokeResponse as part of the outcomeResponses property.
        /// </summary>
        [DataMember]
        public string selectedOutcomeId
        {
            get;
            set;
        }

        /// <summary>
        /// The page data that has been provided by the user so far.
        /// </summary>
        [DataMember]
        public PageRequestAPI pageRequest
        {
            get;
            set;
        }
    }
}
