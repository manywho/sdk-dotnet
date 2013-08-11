using System;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Social
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class WhoAPI
    {
        [DataMember]
        public String id
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

        [DataMember]
        public String fullName 
        { 
            get; 
            set; 
        }

        [DataMember]
        public Boolean isFollower 
        { 
            get; 
            set; 
        }
    }
}
