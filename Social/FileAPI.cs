using System;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Social
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class FileAPI
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
        public Int64 size 
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

        [DataMember]
        public String url 
        { 
            get; 
            set; 
        }

        [DataMember]
        public String delete_url
        { 
            get; 
            set; 
        }

        [DataMember]
        public String thumbnail_url
        { 
            get; 
            set; 
        }

        [DataMember]
        public String delete_type
        { 
            get; 
            set; 
        }
    }
}
