using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Translate;

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
    public class DescribeServiceResponseAPI : DescribeServiceResponseBaseAPI
    {
        /// <summary>
        /// The culture for the service request.
        /// </summary>
        public CultureAPI culture
        {
            get;
            set;
        }

        /// <summary>
        /// The Uri for the service to describe.
        /// </summary>
        public String uri
        {
            get;
            set;
        }

        /// <summary>
        /// The actions available for this service.  The actions are basically a proxy for methods.
        /// </summary>
        public List<DescribeServiceActionResponseAPI> actions
        {
            get;
            set;
        }

        /// <summary>
        /// Contains the description of model elements we'd like to install as part of this service.  When something is installed,
        /// it simply takes the information from the insert as if it were done by the designer (e.g. no translations, it's basically 
        /// just the meta-data, but can only be modified by the service - not the end user (except translations of labels, etc)).  
        /// If the service gets updated, then those changes are applied as if they're a different version of this type.
        /// </summary>
        public DescribeServiceInstallResponseAPI install
        {
            get;
            set;
        }
    }
}