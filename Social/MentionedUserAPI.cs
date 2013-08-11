using System;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Social
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class MentionedUserAPI
    {
        [DataMember]
        public String id 
        { 
            get; 
            set; 
        }

        [DataMember]
        public String name 
        { 
            get; 
            set; 
        }

        [DataMember]
        public String fullName 
        { 
            get; 
            set; 
        }

        [DataMember]
        public String jobTitle 
        { 
            get; 
            set; 
        }

        [DataMember]
        public String avatarUrl 
        { 
            get; 
            set; 
        }
    }
}
