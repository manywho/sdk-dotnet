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

namespace ManyWho.Flow.SDK.Draw.Elements.UI
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class PageConditionAPI
    {
        /// <summary>
        /// The list of page rules that should be evaluated for this condition. If the page rules evaluate to
        /// <code>true</code>, the condition will execute the associated page operations.
        /// </summary>
        /// <remarks>
        /// Each page rule represents an “if” statement (e.g. <code>if x > y…</code>). If the page rule is true, then
        /// the associated page operations will be performed. 
        /// </remarks>
        [DataMember]
        public List<PageRuleAPI> pageRules
        {
            get;
            set;
        }

        /// <summary>
        /// The comparison to use when evaluating the page rules associated with this page condition.
        /// </summary>
        /// <remarks>
        /// Value values are:
        /// 
        /// <ul>
        /// <li><strong>AND</strong>: Compare each rule entry using an <code>AND</code>. This means that all rules in
        /// the comparison must be true for this outcome to be selected.</li>
        /// <li><strong>OR</strong>: Compare each rule entry using an <code>OR</code>. This means that any of the rules
        /// in the comparison must be true for this outcome to be selected.</li>
        /// </ul>
        /// </remarks>
        [DataMember]
        public string comparisonType
        {
            get;
            set;
        }

        /// <summary>
        /// These are the actions to be performed based on the above rules evaluating to true.
        /// </summary>
        /// <remarks>
        /// We do not need to bind a specific field to events as we consider all fields as event generating in the UI
        /// by default. If we want to do smart optimization, we need to look at each of the rules and derive which
        /// fields to bind events from that - we don't explicitly give a list.
        /// </remarks>
        [DataMember]
        public List<PageOperationAPI> pageOperations
        {
            get;
            set;
        }
        
        [DataMember]
        public string generatedSummary
        {
            get;
            set;
        }

    }
}