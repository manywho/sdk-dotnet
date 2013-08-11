using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
