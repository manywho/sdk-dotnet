﻿using System.Collections.Generic;
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
        // Indicates that redirect_uris generated for redirect based authentication services should be based upon the incoming host information (i.e regional domains)
        // and not static platform configuration
        [DataMember]
        public bool authRedirectToRegionalInstance
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates that the Admin APIs should be protected by the provided IP ranges in `authorizedAdminIPRanges`.
        /// Setting this to `false` will not remove the list of IP Range entries and will simply disable IP range 
        /// restrictions
        /// </summary>
        [DataMember]
        public bool isAdminRestrictedByIPRange
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
        public bool isPackagingRestrictedByIPRange
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
        public bool isDrawRestrictedByIPRange
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
        public bool isRunRestrictedByIPRange
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

        [DataMember]
        public bool isSamlEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Settings related to SAML authentication
        /// </summary>
        [DataMember]
        public SamlSettings samlSettings
        {
            get;
            set;
        }
    }
}
