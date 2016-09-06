using System;
using System.Collections.Generic;
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

namespace ManyWho.Flow.SDK.Draw.Elements.Config
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ServiceElementRequestAPI : ServiceElementAPI
    {
        [DataMember]
        public String uri
        {
            get;
            set;
        }

        [DataMember]
        public String format
        {
            get;
            set;
        }

        [DataMember]
        public List<ServiceValueRequestAPI> configurationValues
        {
            get;
            set;
        }

        [DataMember]
        public Boolean providesLogic
        {
            get;
            set;
        }

        [DataMember]
        public Boolean providesViews
        {
            get;
            set;
        }

        [DataMember]
        public Boolean providesFiles
        {
            get;
            set;
        }

        [DataMember]
        public Boolean providesDatabase
        {
            get;
            set;
        }

        [DataMember]
        public Boolean providesIdentity
        {
            get;
            set;
        }

        [DataMember]
        public Boolean providesSocial
        {
            get;
            set;
        }

        [DataMember]
        public Boolean providesLocation
        {
            get;
            set;
        }

        [DataMember]
        public bool providesAutoBinding
        {
            get;
            set;
        }

        [DataMember]
        public List<ServiceActionRequestAPI> actions
        {
            get;
            set;
        }

        [DataMember]
        public ServiceInstallRequestAPI install
        {
            get;
            set;
        }

        [DataMember]
        public Boolean updateByName
        {
            get;
            set;
        }

        [DataMember]
        public bool sendDecryptedValues
        {
            get;
            set;
        }
    }
}