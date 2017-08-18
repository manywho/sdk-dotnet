using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

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
    public class AuthenticatedWho : IAuthenticatedWho
    {
        [DataMember]
        [JsonProperty("manywhoUserId")]
        public Guid ManyWhoUserId
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("manywhoTenantId")]
        public Guid ManyWhoTenantId
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("manywhoToken")]
        public String ManyWhoToken
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("geoLocation")]
        public IGeoLocation GeoLocation
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("userId")]
        public String UserId
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("username")]
        public String Username
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("email")]
        public String Email
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("identityProvider")]
        public String IdentityProvider
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("token")]
        public String Token
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("tenantName")]
        public String TenantName
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("directoryName")]
        public String DirectoryName
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("directoryId")]
        public String DirectoryId
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("roleName")]
        public String RoleName
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("roleId")]
        public String RoleId
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("primaryGroupName")]
        public String PrimaryGroupName
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("primaryGroupId")]
        public String PrimaryGroupId
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("firstName")]
        public String FirstName
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("lastName")]
        public String LastName
        {
            get;
            set;
        }
    }
}
