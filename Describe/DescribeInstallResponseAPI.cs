using ManyWho.Flow.SDK.Draw.Elements.Type;
using System.Collections.Generic;

namespace ManyWho.Flow.SDK.Describe
{
    public class DescribeInstallResponseAPI
    {
        /// <summary>
        /// The actions available for this service.  The actions are basically a proxy for methods.
        /// </summary>
        public List<DescribeServiceActionResponseAPI> Actions
        {
            get;
            set;
        }

        public List<TypeElementRequestAPI> Types
        {
            get;
            set;
        }
    }
}
