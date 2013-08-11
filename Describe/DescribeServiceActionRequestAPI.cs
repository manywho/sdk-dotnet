using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Describe
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class DescribeServiceActionRequestAPI
    {
        /// <summary>
        /// The Uri part to identify the action this data pertains to.
        /// </summary>
        [DataMember]
        public String uriPart
        {
            get;
            set;
        }

        /// <summary>
        /// The service inputs that need to be provided.
        /// </summary>
        [DataMember]
        public List<DescribeValueAPI> serviceInputs
        {
            get;
            set;
        }

        /// <summary>
        /// The service outputs that will be provided back.
        /// </summary>
        [DataMember]
        public List<DescribeValueAPI> serviceOutputs
        {
            get;
            set;
        }
    }
}
