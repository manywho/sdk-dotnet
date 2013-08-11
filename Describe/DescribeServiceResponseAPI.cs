using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
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
    public class DescribeServiceResponseAPI
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
        /// Configuration information that's required to set up the service.  These are values that are typically not associated with
        /// input/output or moment in time information - this is stuff that is required for the service to function correctly.
        /// </summary>
        [DataMember]
        public List<DescribeValueAPI> configurationValues
        {
            get;
            set;
        }

        /// <summary>
        /// Tells the system whether or not the service exposes logic actions.
        /// </summary>
        [DataMember]
        public Boolean exposesLogic
        {
            get;
            set;
        }

        /// <summary>
        /// Tells the system whether or not the service exposes views.
        /// </summary>
        [DataMember]
        public Boolean exposesViews
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if this service provides object data support for the provided types.
        /// </summary>
        [DataMember]
        public Boolean exposesTables
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if this service provides identity information for authentication and authorization calls.
        /// </summary>
        [DataMember]
        public Boolean providesIdentity
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if this service provides social networking capabilities to the flow.
        /// </summary>
        [DataMember]
        public Boolean providesSocial
        {
            get;
            set;
        }

        /// <summary>
        /// The actions available for this service.  The actions are basically a proxy for methods.
        /// </summary>
        [DataMember]
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
        [DataMember]
        public DescribeServiceInstallResponseAPI install
        {
            get;
            set;
        }
    }
}