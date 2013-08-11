using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Social
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class NewMessageAPI
    {
        public NewMessageAPI()
        {
            this.uploadedFiles = new List<FileAPI>();
            this.mentionedUsers = new List<MentionedUserAPI>();
        }

        [DataMember]
        public String senderId 
        { 
            get;
            set;
        }

        [DataMember]
        public String messageText 
        { 
            get; 
            set; 
        }

        [DataMember]
        public String repliedTo 
        { 
            get; 
            set; 
        }

        [DataMember]
        public List<FileAPI> uploadedFiles 
        { 
            get; 
            set; 
        }

        [DataMember]
        public List<MentionedUserAPI> mentionedUsers 
        { 
            get; 
            set; 
        }
    }
}
