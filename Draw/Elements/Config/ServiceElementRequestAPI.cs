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
        /// <summary>
        /// The location of the Service implementation for the platform to callout against.
        /// </summary>
        [DataMember]
        public string uri
        {
            get;
            set;
        }

        /// <summary>
        /// The REST messaging format to use to communicate with this service. Currently the only valid value for this property is: JSON
        /// </summary>
        [DataMember]
        public string format
        {
            get;
            set;
        }

        /// <summary>
        /// The list of configuration value mappings the service needs to function. Each entry provides a reference to a Value in the Flow that contains the configuration value needed by the service plugin.
        /// </summary>
        [DataMember]
        public List<ServiceValueRequestAPI> configurationValues
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the Service provides functionality for 'logic'. Logic allows authors to make API calls as part of elements that support messaging: 'Message', 'Page', and 'Remote Page' currently. Messaging is used for asynchronous and synchronous use-cases.
        /// </summary>
        [DataMember]
        public bool providesLogic
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the Service provides functionality for 'views'. A View allows authors to build Flows that include 'Remote Page' elements - e.g. the UI of the page is not actually hosted on the ManyWho platform, but rather the UI is provided by the external service.
        /// </summary>
        [DataMember]
        public bool providesViews
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the Service provides functionality for 'files'. Files allows the author to reference files and content from the service as dynamic references - meaning that the files and content can be managed outside of ManyWho, but embedded in your Flows.
        /// </summary>
        [DataMember]
        public bool providesFiles
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the Service provides functionality for 'database'. Database functionality allows the author to map their Typed Objects and Lists back to this service for storage. The service then acts as the persistence implementation to store and retrieve the data as neede by the Flow.
        /// </summary>
        [DataMember]
        public bool providesDatabase
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the Service provides functionality for 'identity'. Identity functionality allows the author to manage permissions to their Flows and sections of their Flows (via Swimlanes) using this service as the directory. This also allows users to login to the Flows using the information stored in this service directory.
        /// </summary>
        [DataMember]
        public bool providesIdentity
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the Service provides functionality for 'social'. Social allows the author to add features for feed, file and user collaboration to their Flows using this service as the underlying social network.
        /// </summary>
        [DataMember]
        public bool providesSocial
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the Service provides functionality for 'location'. ManyWho optionally collects location information about the user when running a Flow. This information can be used to make decisions about permissions and also data filtering - though it is up to the service to implement this functionality.
        /// </summary>
        [DataMember]
        public bool providesLocation
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

        /// <summary>
        /// The list of 'logic' operations that are available for the service. If the underlying service 'providesLogic', this is where the 'interface' for those logic operations should be stored. This allows the author to know what inputs and outputs are provided by the actions provided by this Service.
        /// </summary>
        [DataMember]
        public List<ServiceActionRequestAPI> actions
        {
            get;
            set;
        }

        /// <summary>
        /// As part of the service creation, you can provide additional installation metadata that will be created as part of the service. This object defines the metadata that this Service wants to create as part of the creation of the Service.
        /// </summary>
        [DataMember]
        public ServiceInstallRequestAPI install
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the platform should attempt to find a Service with the same developer name as the one provided and match them up by name as opposed to 'id'. This is useful when creating scripts to create Flows - as you can use the developerName property as the reference as opposed to needing to know the ids of all created elements.
        /// </summary>
        [DataMember]
        public bool updateByName
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

        public string HttpAuthenticationUsername
        {
            get;
            set;
        }

        public string HttpAuthenticationPassword
        {
            get;
            set;
        }

        public string Version
        {
            get;
            set;
        }
    }
}