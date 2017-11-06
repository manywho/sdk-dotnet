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

namespace ManyWho.Flow.SDK.Security
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class SecuritySettingsAPI
    {
        /// <summary>
        /// A boolean value indicating if requests to the Admin API are restricted by IP range. If this is true, the list of IP ranges should be listed in the authorizedAdminIPRanges property
        /// </summary>
        [DataMember]
        public Boolean isAdminRestrictedByIPRange
        {
            get;
            set;
        }

        /// <summary>
        /// A boolean value indicating if requests to the Package API are restricted by IP range. If this is true, the list of IP ranges should be listed in the authorizedPackagingIPRanges property
        /// </summary>
        [DataMember]
        public Boolean isPackagingRestrictedByIPRange
        {
            get;
            set;
        }

        /// <summary>
        /// A boolean value indicating if requests to the Draw API are restricted by IP range. If this is true, the list of IP ranges should be listed in the authorizedDrawIPRanges property
        /// </summary>
        [DataMember]
        public Boolean isDrawRestrictedByIPRange
        {
            get;
            set;
        }

        /// <summary>
        /// A boolean value indicating if requests to the Run API are restricted by IP range. If this is true, the list of IP ranges should be listed in the authorizedRunIPRanges property
        /// </summary>
        [DataMember]
        public Boolean isRunRestrictedByIPRange
        {
            get;
            set;
        }

        /// <summary>
        /// A boolean value indicating if running Flows can send data to Services that are not explicitly listed
        /// </summary>
        [DataMember]
        public Boolean isServiceRestrictedByRemoteSites
        {
            get;
            set;
        }

        /// <summary>
        /// A list of IP ranges that requests to the Admin API must originate from to gain access
        /// </summary>
        [DataMember]
        public List<IPRangeAPI> authorizedAdminIPRanges
        {
            get;
            set;
        }

        /// <summary>
        /// A list of IP ranges that requests to the Packaging API must originate from to gain access
        /// </summary>
        [DataMember]
        public List<IPRangeAPI> authorizedPackagingIPRanges
        {
            get;
            set;
        }

        /// <summary>
        /// A list of IP ranges that requests to the Draw API must originate from to gain access
        /// </summary>
        [DataMember]
        public List<IPRangeAPI> authorizedDrawIPRanges
        {
            get;
            set;
        }

        /// <summary>
        /// A list of IP ranges that requests to the Run API must originate from to gain access
        /// </summary>
        [DataMember]
        public List<IPRangeAPI> authorizedRunIPRanges
        {
            get;
            set;
        }

        /// <summary>
        /// A list of remote site addresses that any Services must adhere to if included in a Flow. If a Flow attempts to connect to a Service not listed as a remote site, the request to the Service will be denied.
        /// </summary>
        [DataMember]
        public List<RemoteSiteAPI> authorizedServiceRemoteSites
        {
            get;
            set;
        }

        /// <summary>
        /// The user registration settings that determine how builder users are added to the tenant
        /// </summary>
        [DataMember]
        public UserRegistrationSettingsAPI userRegistrationSettings
        {
            get;
            set;
        }
    }
}
