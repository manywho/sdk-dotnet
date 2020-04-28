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

using Newtonsoft.Json;

namespace ManyWho.Flow.SDK.Restrictions
{
    public class FlowRestrictionsAPI
    {
        /// <summary>
        /// Specifies geographical regions where a flow can be run (i.e. the Engine instances that can execute it)
        /// </summary>
        [JsonProperty("execution")]
        public RestrictionAPI Execution
        {
            get;
            set;
        }
        
        /// <summary>
        /// Specifies geographical regions where a flow can be accessed at runtime (i.e. the countries where a flow can be run from)
        /// </summary>
        [JsonProperty("access")]
        public RestrictionAPI Access
        {
            get;
            set;
        }
    }
}