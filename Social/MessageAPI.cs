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

namespace ManyWho.Flow.SDK.Social
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class MessageAPI
    {
        public MessageAPI()
        {
            this.attachments = new List<AttachmentAPI>();
            this.comments = new List<MessageAPI>();
            this.likerIds = new List<String>();
        }

        [DataMember]
        public String id
        { 
            get; 
            set; 
        }

        [DataMember]
        public String repliedToId 
        { 
            get; 
            set; 
        }

        [DataMember]
        public String text 
        { 
            get; 
            set; 
        }

        [DataMember]
        public DateTime createdDate 
        { 
            get; 
            set; 
        }

        [DataMember]
        public WhoAPI sender 
        { 
            get; 
            set; 
        }

        [DataMember]
        public List<AttachmentAPI> attachments 
        { 
            get; 
            set; 
        }

        [DataMember]
        public List<MessageAPI> comments 
        { 
            get; 
            set; 
        }

        [DataMember]
        public List<String> likerIds 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// This property is not sent back to the caller
        /// </summary>
        public String myLikeId
        {
            get;
            set;
        }

        public Int32 commentsCount
        {
            get;
            set;
        }
    }
}
