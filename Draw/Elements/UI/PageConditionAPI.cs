using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Map;

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