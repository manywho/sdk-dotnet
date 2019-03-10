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

namespace ManyWho.Flow.SDK.Run.Elements.Config
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ListenerServiceRequestAPI : BaseRequestAPI
    {
        /// <summary>
        /// The type of listening the Service should do on the provide value. The listen types are determined by the Service as there can be many types of events the listener may be interested in "hearing".
        /// </summary>
        [DataMember]
        public string listenType
        {
            get;
            set;
        }

        /// <summary>
        /// The value that should be listened to. This is a ContentObject that contains the necessary identifiers and data to inform the Service. For example, this could be the description information of a File, or the details of a record in the underlying Service database.
        /// </summary>
        [DataMember]
        public EngineValueAPI valueForListening
        {
            get;
            set;
        }
    }
}
