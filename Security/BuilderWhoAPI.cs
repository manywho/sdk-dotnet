using System;
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
    public class BuilderWhoAPI
    {
        /// <summary>
        /// The unique identifier for the builder on ManyWho. This identifier is the same across all tenants for which the builder has permissions.
        /// </summary>
        [DataMember]
        public String id
        {
            get;
            set;
        }

        /// <summary>
        /// The first name of the builder
        /// </summary>
        [DataMember]
        public String firstName
        {
            get;
            set;
        }

        /// <summary>
        /// The last name of the builder
        /// </summary>
        [DataMember]
        public String lastName
        {
            get;
            set;
        }

        /// <summary>
        /// The email of the builder
        /// </summary>
        [DataMember]
        public String email
        {
            get;
            set;
        }

        /// <summary>
        /// The username of the builder for this tenant on ManyWho
        /// </summary>
        [DataMember]
        public String username
        {
            get;
            set;
        }

        [DataMember]
        public bool verified
        {
            get;
            set;
        }
    }
}
