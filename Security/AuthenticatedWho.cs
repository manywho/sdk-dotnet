using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Errors;
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
        private Guid? manywhoTenantId = null;

        public AuthenticatedWho()
        {
        }

        public AuthenticatedWho(IAuthenticatedWho user)
        {
            if (user == null)
            {
                return;
            }
            
            ManyWhoUserId = user.ManyWhoUserId;
            ManyWhoTenantId = user.ManyWhoTenantIdMust;
            ManyWhoToken = user.ManyWhoToken;
            GeoLocation = user.GeoLocation;
            UserId = user.UserId;
            Username = user.Username;
            Email = user.Email;
            IdentityProvider = user.IdentityProvider;
            Token = user.Token;
            TenantName = user.TenantName;
            DirectoryName = user.DirectoryName;
            DirectoryId = user.DirectoryId;
            RoleName = user.RoleName;
            RoleId = user.RoleId;
            PrimaryGroupName = user.PrimaryGroupName;
            PrimaryGroupId = user.PrimaryGroupId;
            FirstName = user.FirstName;
            LastName = user.LastName;
        }

        [DataMember]
        [JsonProperty("manywhoUserId")]
        public Guid ManyWhoUserId
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("manywhoTenantId")]
        public Guid? ManyWhoTenantId
        {
            get
            {
                return manywhoTenantId;
            }
            set
            {
                if(value == Guid.Empty)
                {
                    throw new EngineException("A tenant id cannot be an empty guid");
                }

                this.manywhoTenantId = value;
            }
        }

        public Guid ManyWhoTenantIdMust
        {
            get
            {
                if(ManyWhoTenantId.HasValue == false)
                {
                    throw new EngineException("A tenant id was requested but was not set");
                }

                return ManyWhoTenantId.Value;
            }
        }

        [DataMember]
        [JsonProperty("manywhoToken")]
        public string ManyWhoToken
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
        public string UserId
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("username")]
        public string Username
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("email")]
        public string Email
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("identityProvider")]
        public string IdentityProvider
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("token")]
        public string Token
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("tenantName")]
        public string TenantName
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("directoryName")]
        public string DirectoryName
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("directoryId")]
        public string DirectoryId
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("roleName")]
        public string RoleName
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("roleId")]
        public string RoleId
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("primaryGroupName")]
        public string PrimaryGroupName
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("primaryGroupId")]
        public string PrimaryGroupId
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("groups")]
        public IList<IGroup> Groups 
        { 
            get; 
            set; 
        }

        [DataMember]
        [JsonProperty("firstName")]
        public string FirstName
        {
            get;
            set;
        }

        [DataMember]
        [JsonProperty("lastName")]
        public string LastName
        {
            get;
            set;
        }
    }
}
