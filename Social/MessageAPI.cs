using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

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
