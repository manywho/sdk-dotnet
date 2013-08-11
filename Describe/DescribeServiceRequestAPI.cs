using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run;
using ManyWho.Flow.SDK.Run.Elements.Config;

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
    public class DescribeServiceRequestAPI
    {
        /// <summary>
        /// The culture for the service request.
        /// </summary>
        [DataMember]
        public CultureAPI culture
        {
            get;
            set;
        }

        /// <summary>
        /// The Uri for the service to describe.
        /// </summary>
        [DataMember]
        public String uri
        {
            get;
            set;
        }

        /// <summary>
        /// Configuration values provided by the end user to help the describe.
        /// </summary>
        [DataMember]
        public List<EngineValueAPI> configurationValues
        {
            get;
            set;
        }
    }
}