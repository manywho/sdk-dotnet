using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ManyWho.Flow.SDK.Notification
{
    [DataContract(Namespace = "http://www.manywho.com")]
    public class NotificationMessage : INotificationMessage
    {
        [JsonProperty("mediaType")]
        [DataMember(Name = "mediaType")]
        public string MediaType
        {
            get;
            set;
        }

        [JsonProperty("message")]
        [DataMember(Name = "message")]
        public string Message
        {
            get;
            set;
        }
    }
}
