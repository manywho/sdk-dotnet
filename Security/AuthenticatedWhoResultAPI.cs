using System;
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

namespace ManyWho.Flow.SDK.Security
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class AuthenticatedWhoResultAPI
    {
        [DataMember]
        public String userId
        {
            get;
            set;
        }

        [DataMember]
        public String email
        {
            get;
            set;
        }

        [DataMember]
        public String username
        {
            get;
            set;
        }

        [DataMember]
        public String firstName
        {
            get;
            set;
        }

        [DataMember]
        public String lastName
        {
            get;
            set;
        }

        [DataMember]
        public String directoryId
        {
            get;
            set;
        }

        [DataMember]
        public String directoryName
        {
            get;
            set;
        }

        [DataMember]
        public String roleId
        {
            get;
            set;
        }

        [DataMember]
        public String roleName
        {
            get;
            set;
        }

        [DataMember]
        public String primaryGroupId
        {
            get;
            set;
        }

        [DataMember]
        public String primaryGroupName
        {
            get;
            set;
        }

        [DataMember]
        public String tenantName
        {
            get;
            set;
        }

        [DataMember]
        public String tenantId
        {
            get;
            set;
        }

        [DataMember]
        public String identityProvider
        {
            get;
            set;
        }

        [DataMember]
        public String token
        {
            get;
            set;
        }

        [DataMember]
        public String status
        {
            get;
            set;
        }

        [DataMember]
        public String statusMessage
        {
            get;
            set;
        }

        [DataMember]
        public CultureAPI culture
        {
            get;
            set;
        }

        public static AuthenticatedWhoResultAPI CreateDeniedResult()
        {
            return CreateDeniedResult("Unable to login with the provided credentials");
        }

        public static AuthenticatedWhoResultAPI CreateDeniedResult(string message)
        {
            return new AuthenticatedWhoResultAPI()
            {
                status = ManyWhoConstants.AUTHENTICATED_USER_STATUS_ACCESS_DENIED,
                statusMessage = message
            };
        }
    }
}
