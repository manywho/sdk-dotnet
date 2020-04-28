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

namespace ManyWho.Flow.SDK.Run
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class EngineAuthorizationContextAPI
    {
        /// <summary>
        /// The name of the directory the user needs to login to. This can be helpful in dialogs so the user knows what system they need to provide credentials for.
        /// </summary>
        [DataMember]
        public string directoryName
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the directory. Again, this can be helpful in dialogs. In this case, for developers as the directory identifier may allow you to gather additional information about what needs to be collected from the user.
        /// </summary>
        [DataMember]
        public string directoryId
        {
            get;
            set;
        }

        /// <summary>
        /// The Url that should be used as part of any authentication request to the runtime.
        /// </summary>
        [DataMember]
        public string loginUrl
        {
            get;
            set;
        }

        /// <summary>
        /// The type of authentication that needs to be performed against the directory.
        /// </summary>
        [DataMember]
        public string authenticationType
        {
            get;
            set;
        }
    }
}
