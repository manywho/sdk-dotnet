using System.Collections.Generic;
using ManyWho.Flow.SDK.Run;

namespace ManyWho.Flow.SDK.Describe
{
    public class DescribeInstallRequestAPI : DescribeServiceRequestAPI
    {
        /// <summary>
        /// Configuration values provided by the end user to help the describe.
        /// </summary>
        public List<EngineValueAPI> ConfigurationValues
        {
            get;
            set;
        }
        public string Version { get; set; }
    }
}
