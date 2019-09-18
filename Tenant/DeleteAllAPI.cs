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

namespace ManyWho.Flow.SDK.Tenant
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class DeleteRequestAPI
    {
        /// <summary>
        /// Indicates if all non-default cultures should be deleted
        /// </summary>
        [DataMember]
        public bool cultures
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if all flows should be deleted
        /// </summary>
        [DataMember]
        public bool flows
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if all page elements should be deleted
        /// </summary>
        [DataMember]
        public bool pages
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if all value elements should be deleted
        /// </summary>
        [DataMember]
        public bool values
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if all type elements should be deleted
        /// </summary>
        [DataMember]
        public bool types
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if all service elements should be deleted
        /// </summary>
        [DataMember]
        public bool services
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if all tag elements should be deleted
        /// </summary>
        [DataMember]
        public bool tags
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if all flow snapshots should be deleted
        /// </summary>
        [DataMember]
        public bool snapshots
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if all flow states should be deleted
        /// </summary>
        [DataMember]
        public bool states
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if all macro elements should be deleted
        /// </summary>
        [DataMember]
        public bool macros
        {
            get;
            set;
        }
    }
}
