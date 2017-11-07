using System;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Security;

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

namespace ManyWho.Flow.SDK.Tenant
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class TenantRequestAPI
    {
        /// <summary>
        /// Summary information about this tenant.
        /// </summary>
        [DataMember]
        public String developerSummary
        {
            get;
            set;
        }

        /// <summary>
        /// Specific security settings that should be applied to this tenant beyond the defaults.
        /// </summary>
        [DataMember]
        public SecuritySettingsAPI securitySettings
        {
            get;
            set;
        }

        /// <summary>
        /// Specific report settings to allow reporting data to be sent to an alternative endpoint.
        /// </summary>
        [DataMember]
        public ReportSettingsAPI reportSettings
        {
            get;
            set;
        }

        [DataMember]
        public string subdomain
        {
            get;
            set;
        }

        [DataMember]
        public StateSettingsAPI stateSettings
        {
            get;
            set;
        }

        [DataMember]
        public TenantSettingsAPI tenantSettings
        {
            get;
            set;
        }
    }
}
