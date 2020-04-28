using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Group;
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

namespace ManyWho.Flow.SDK.Run.Elements.Config
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class BaseRequestAPI
    {
        /// <summary>
        /// The execution token needed for any callback responses from the Service.
        /// </summary>
        [DataMember]
        public string token
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the tenant making the request to the Service.
        /// </summary>
        [DataMember]
        public string tenantId
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the Flow State making the request to the Service.
        /// </summary>
        [DataMember]
        public string stateId
        {
            get;
            set;
        }

        /// <summary>
        /// The Uri that should be used for any callbacks made from the Service to ManyWho.
        /// </summary>
        [DataMember]
        public string callbackUri
        {
            get;
            set;
        }

        /// <summary>
        /// The URI of the Flow platform that sent the request
        /// </summary>
        [DataMember]
        public string platformUri
        {
            get;
            set;
        }

        /// <summary>
        /// The Culture of the user whose action generated the request to the Service.
        /// </summary>
        [DataMember]
        public CultureAPI culture
        {
            get;
            set;
        }

        /// <summary>
        /// The array of configuration values are needed for the Service to operate correctly. Services should not store tenant specific authentication information.
        /// </summary>
        [DataMember]
        public List<EngineValueAPI> configurationValues
        {
            get;
            set;
        }

        /// <summary>
        /// The authorization context the request should be executed within. The Authorization object informs the Service about access rights specified by the builder user.
        /// </summary>
        [DataMember]
        public GroupAuthorizationAPI authorization
        {
            get;
            set;
        }

        /// <summary>
        /// Any runtime annotations that were provided to the State.
        /// </summary>
        [DataMember]
        public Dictionary<string, string> annotations
        {
            get;
            set;
        }

        /// <summary>
        /// Arbitrary key value pairs that may help the Service execute this request. Use attributes to extend our metadata with implementation specific settings.
        /// </summary>
        [DataMember]
        public Dictionary<string, string> attributes
        {
            get;
            set;
        }
    }
}
