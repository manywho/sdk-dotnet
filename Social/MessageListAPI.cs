using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Social
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class MessageListAPI
    {
        public MessageListAPI()
        {
            messages = new List<MessageAPI>();
        }

        [DataMember]
        public List<MessageAPI> messages
        {
            get;
            set;
        }

        [DataMember]
        public String nextPage
        {
            get;
            set;
        }
    }
}
