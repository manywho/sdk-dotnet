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
    public class ListenerServiceResponseAPI : BaseResponseAPI
    {
        /// <summary>
        /// The value that had the event. This is a ContentObject that contains the necessary identifiers and data from the Service. This value should contain any updated information but should be symmetrical with the valueForListening provided in the request (i.e. it should be the same value).
        /// </summary>
        [DataMember]
        public EngineValueAPI listeningEventValue
        {
            get;
            set;
        }
    }
}
