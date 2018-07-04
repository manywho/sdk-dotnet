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
        public string userId
        {
            get;
            set;
        }

        [DataMember]
        public string email
        {
            get;
            set;
        }

        [DataMember]
        public string username
        {
            get;
            set;
        }

        [DataMember]
        public string firstName
        {
            get;
            set;
        }

        [DataMember]
        public string lastName
        {
            get;
            set;
        }

        [DataMember]
        public string directoryId
        {
            get;
            set;
        }

        [DataMember]
        public string directoryName
        {
            get;
            set;
        }

        [DataMember]
        public string roleId
        {
            get;
            set;
        }

        [DataMember]
        public string roleName
        {
            get;
            set;
        }

        [DataMember]
        public string primaryGroupId
        {
            get;
            set;
        }

        [DataMember]
        public string primaryGroupName
        {
            get;
            set;
        }

        [DataMember]
        public string tenantName
        {
            get;
            set;
        }

        [DataMember]
        public string tenantId
        {
            get;
            set;
        }

        [DataMember]
        public string identityProvider
        {
            get;
            set;
        }

        [DataMember]
        public string token
        {
            get;
            set;
        }

        [DataMember]
        public string status
        {
            get;
            set;
        }

        [DataMember]
        public string statusMessage
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
    }
}
