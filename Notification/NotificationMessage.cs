using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using ManyWho.Flow.SDK.Utils;

namespace ManyWho.Flow.SDK.Utils
{
    [DataContract(Namespace = "http://www.manywho.com")]
    public class NotificationMessage : INotificationMessage
    {
        [JsonProperty("mediaType")]
        [DataMember(Name = "mediaType")]
        public String MediaType
        {
            get;
            set;
        }

        [JsonProperty("message")]
        [DataMember(Name = "message")]
        public String Message
        {
            get;
            set;
        }
    }
}
