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
    /// <summary>
    /// Specific security settings that should be applied to this tenant, beyond the defaults (excluding subtenants)
    /// </summary>
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class SecuritySettingsAPI
    {
        /// <summary>
        /// Indicates that the Admin APIs should be protected by the provided IP ranges in `authorizedAdminIPRanges`.
        /// Setting this to `false` will not remove the list of IP Range entries and will simply disable IP range 
        /// restrictions
        /// </summary>
        [DataMember]
        public Boolean isAdminRestrictedByIPRange
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates that the Packaging APIs should be protected by the provided IP ranges in 
        /// `authorizedPackagingIPRanges`. Setting this to `false` will not remove the list of IP Range entries and will 
        /// simply disable IP range restrictions
        /// </summary>
        [DataMember]
        public Boolean isPackagingRestrictedByIPRange
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates that the Draw APIs should be protected by the provided IP ranges in `authorizedDrawIPRanges`. 
        /// Setting this to `false` will not remove the list of IP Range entries and will simply disable IP range 
        /// restrictions
        /// </summary>
        [DataMember]
        public Boolean isDrawRestrictedByIPRange
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates that the Run APIs should be protected by the provided IP ranges in `authorizedRunIPRanges`. 
        /// Setting this to `false` will not remove the list of IP Range entries and will simply disable IP range 
        /// restrictions
        /// </summary>
        [DataMember]
        public Boolean isRunRestrictedByIPRange
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates that services may only be allowed to be installed and used based on the settings outlined 
        /// in the `authorizedServiceRemoteSites` property. Setting this to `false` will not remove the existing Remote 
        /// Site settings
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
        /// A list of IP ranges that requests to the Packaging API must originate from to be allowed access
        /// </summary>
        [DataMember]
        public List<IPRangeAPI> authorizedPackagingIPRanges
        {
            get;
            set;
        }

        /// <summary>
        /// A list of IP ranges that requests to the Draw API must originate from to to be allowed access
        /// </summary>
        [DataMember]
        public List<IPRangeAPI> authorizedDrawIPRanges
        {
            get;
            set;
        }

        /// <summary>
        /// A list of IP ranges that requests to the Run API must originate from to be allowed access
        /// </summary>
        [DataMember]
        public List<IPRangeAPI> authorizedRunIPRanges
        {
            get;
            set;
        }

        /// <summary>
        /// A list of remote site addresses that any services must adhere to if included in a flow. If a flow attempts 
        /// to connect to a service not listed as a remote site, the request to the service will be denied
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
        [Obsolete]
        public UserRegistrationSettingsAPI userRegistrationSettings
        {
            get;
            set;
        }
    }
}
