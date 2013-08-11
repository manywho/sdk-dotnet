using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Social;

namespace ManyWho.Flow.SDK.Run.Elements.Config
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class SocialServiceRequestAPI : ServiceRequestAPI
    {
        [DataMember]
        public NewMessageAPI newMessage
        {
            get;
            set;
        }

        [DataMember]
        public String page
        {
            get;
            set;
        }

        [DataMember]
        public Int32 pageSize
        {
            get;
            set;
        }

        [DataMember]
        public AttachmentAPI attachment
        {
            get;
            set;
        }
    }
}
