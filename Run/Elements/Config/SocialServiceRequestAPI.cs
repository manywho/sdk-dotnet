using System;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Social;

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
    public class SocialServiceRequestAPI : ServiceRequestAPI
    {
        /// <summary>
        /// The message that should be posted to the Service.
        /// </summary>
        [DataMember]
        public NewMessageAPI newMessage
        {
            get;
            set;
        }

        /// <summary>
        /// The current page of messages that should be sent.
        /// </summary>
        [DataMember]
        public String page
        {
            get;
            set;
        }

        /// <summary>
        /// The number of messages to include on the page response.
        /// </summary>
        [DataMember]
        public Int32 pageSize
        {
            get;
            set;
        }

        /// <summary>
        /// The details of the file attachment that should be uploaded with the message post.
        /// </summary>
        [DataMember]
        public AttachmentAPI attachment
        {
            get;
            set;
        }
    }
}
