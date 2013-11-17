using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    [Serializable]
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class AuthenticatedWho : IAuthenticatedWho
    {
        [DataMember]
        public Guid ManyWhoUserId
        {
            get;
            set;
        }

        [DataMember]
        public Guid ManyWhoTenantId
        {
            get;
            set;
        }

        [DataMember]
        public String ManyWhoToken
        {
            get;
            set;
        }

        [DataMember]
        public IGeoLocation GeoLocation
        {
            get;
            set;
        }

        [DataMember]
        public String UserId
        {
            get;
            set;
        }

        [DataMember]
        public String Email
        {
            get;
            set;
        }

        [DataMember]
        public String IdentityProvider
        {
            get;
            set;
        }

        [DataMember]
        public String Token
        {
            get;
            set;
        }

        [DataMember]
        public String TenantName
        {
            get;
            set;
        }

        [DataMember]
        public String DirectoryName
        {
            get;
            set;
        }

        [DataMember]
        public String DirectoryId
        {
            get;
            set;
        }
    }
}
