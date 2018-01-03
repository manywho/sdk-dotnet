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

namespace ManyWho.Flow.SDK.Draw.Flow
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class FlowResponseAPI : FlowRequestAPI
    {
        /// <summary>
        /// The date and time the flow was created at
        /// </summary>
        [DataMember]
        public DateTimeOffset dateCreated
        {
            get;
            set;
        }

        /// <summary>
        /// The date and time of the last modification to the flow
        /// </summary>
        [DataMember]
        public DateTimeOffset dateModified
        {
            get;
            set;
        }

        /// <summary>
        /// The builder who created the flow
        /// </summary>
        [DataMember]
        public BuilderWhoAPI whoCreated
        {
            get;
            set;
        }

        /// <summary>
        /// The builder who last modified the flow
        /// </summary>
        [DataMember]
        public BuilderWhoAPI whoModified
        {
            get;
            set;
        }

        /// <summary>
        /// The builder who owns the flow
        /// </summary>
        [DataMember]
        public BuilderWhoAPI whoOwner
        {
            get;
            set;
        }

        /// <summary>
        /// The email of the builder who activated the flow
        /// </summary>
        [DataMember]
        public string alertEmail
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if this flow version is the active version.
        /// </summary>
        /// <remarks>
        /// In the case of run operations this will always be true, and for draw operations this will be false.
        /// </remarks>
        [DataMember]
        public bool isActive
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if this flow version is the default version.
        /// </summary>
        /// <remarks>
        /// In the case of run operations this will always be true, and for draw operations this will be false.
        /// </remarks>
        [DataMember]
        public bool isDefault
        {
            get;
            set;
        }

        /// <summary>
        /// The activation comment provided by the builder, if given
        /// </summary>
        [DataMember]
        public string comment
        {
            get;
            set;
        }
    }
}