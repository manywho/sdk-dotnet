using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace ManyWho.Flow.SDK.Run.Elements.Config
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ListenerServiceRequestAPI : BaseRequestAPI
    {
        /// <summary>
        /// If this service request is to listen to events, then the listen type will be provided so the service can register this request
        /// for the right events.
        /// </summary>
        [DataMember]
        public String listenType
        {
            get;
            set;
        }

        /// <summary>
        /// The value that the remote service should refer to to associate the listening request.
        /// </summary>
        [DataMember]
        public EngineValueAPI valueForListening
        {
            get;
            set;
        }
    }
}
