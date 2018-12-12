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
    public class ComparisonAPI
    {
        /// <summary>
        /// The comparison to use when evaluating the immediate child rules associated with this comparison object.
        /// </summary>
        [DataMember]
        public string comparisonType
        {
            get;
            set;
        }

        /// <summary>
        /// The list of rules that need to be evaluated for this outcome to be selected.
        /// </summary>
        [DataMember]
        public List<RuleAPI> rules
        {
            get;
            set;
        }

        /// <summary>
        /// The list of child comparisons that need to be evaluated for this outcome to be selected. The comparison object is recursive allowing rules to be nested: e.g. ({a} > {b} OR {c} <= {d}) AND {b} == {f}
        /// </summary>
        [DataMember]
        public List<ComparisonAPI> comparisons
        {
            get;
            set;
        }

        /// <summary>
        /// The order in which the comparison should be evaluated with respect to its peers. The lowest number is evaluated first.
        /// </summary>
        [DataMember]
        public int order
        {
            get;
            set;
        }
    }
}