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
        /// This is the other side of the value for listening that will have been passed in. The listening event value should be the same
        /// value with any updates to the data.
        /// </summary>
        [DataMember]
        public EngineValueAPI listeningEventValue
        {
            get;
            set;
        }
    }
}
