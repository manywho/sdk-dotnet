using System;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Social
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class AttachmentAPI
    {
        [DataMember]
        public String name 
        { 
            get; 
            set; 
        }

        [DataMember]
        public String iconUrl 
        { 
            get; 
            set; 
        }

        [DataMember]
        public String downloadUrl 
        { 
            get; 
            set; 
        }

        [DataMember]
        public String size 
        { 
            get; 
            set; 
        }

        [DataMember]
        public String description 
        { 
            get; 
            set; 
        }

        [DataMember]
        public String type 
        { 
            get; 
            set; 
        }
    }
}
