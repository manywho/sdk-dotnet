using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Map;

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

namespace ManyWho.Flow.SDK.Draw.Elements.UI
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageConditionAPI
    {
        [DataMember]
        public List<PageRuleAPI> pageRules
        {
            get;
            set;
        }

        /// <summary>
        /// The rules that must evaluate to "true" for this condition to fire the associated actions.
        /// </summary>
        [DataMember]
        public String comparison
        {
            get;
            set;
        }

        /// <summary>
        /// These are the actions to be performed based on the above rules evaluating to true.  We do not need to bind a specific field
        /// to events as we consider all fields as event generating in the UI by default.  If we want to do smart optimization, we need
        /// to look at each of the rules and derive which fields to bind events from that - we don't explicitly give a list.
        /// </summary>
        [DataMember]
        public List<PageOperationAPI> pageOperations
        {
            get;
            set;
        }
    }
}