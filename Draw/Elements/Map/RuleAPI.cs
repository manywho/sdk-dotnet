using System;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Value;

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
    public class RuleAPI
    {
        /// <summary>
        /// The reference to the Value that should be used for the "left" side of the rule evaluation: e.g. if {left} is greater than {right} then ...
        /// </summary>
        [DataMember]
        public ValueElementIdAPI leftValueElementToReferenceId
        {
            get;
            set;
        }

        /// <summary>
        /// The criteria that should be used when evaluating this rule: e.g. EQUAL
        /// </summary>
        [DataMember]
        public String criteriaType
        {
            get;
            set;
        }

        /// <summary>
        /// The reference to the Value that should be used for the "right" side of the rule evaluation: e.g. if {left} is greater than {right} then ...
        /// </summary>
        [DataMember]
        public ValueElementIdAPI rightValueElementToReferenceId
        {
            get;
            set;
        }

        [DataMember]
        public string leftValueElementToReferenceDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public string rightValueElementToReferenceDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public string criteriaTypeFriendly
        {
            get;
            set;
        }
    }
}