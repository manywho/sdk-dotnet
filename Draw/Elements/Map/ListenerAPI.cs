using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Value;

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

namespace ManyWho.Flow.SDK.Draw.Elements.Map
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ListenerAPI
    {
        /// <summary>
        /// The developer name for the Listener. This is useful for keeping track of the Listener in the modeling tool and API.
        /// </summary>
        [DataMember]
        public String developerName
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the Service that this Listener configuration is associated. The Service must support listening to the object you've selected to listen to.
        /// </summary>
        [DataMember]
        public String serviceElementId
        {
            get;
            set;
        }

        /// <summary>
        /// The type of Listener this metadata represents. The ListenerType is determined by the Service, though there are some basic ListenerTypes built into the tooling.
        /// </summary>
        [DataMember]
        public String listenerType
        {
            get;
            set;
        }

        [DataMember]
        public ValueElementIdAPI valueElementToReferenceForListeningId
        {
            get;
            set;
        }

        /// <summary>
        /// Arbitrary key value pairs that may help the Service execute the Listener. Use attributes to extend our Listener metadata with implementation specific settings.
        /// </summary>
        [DataMember]
        public Dictionary<String, String> attributes
        {
            get;
            set;
        }
    }
}
