using System;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Service
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ServiceRequestAPI
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public Guid TenantId { get; set; }
        [DataMember]
        public Guid StateId { get; set; }
        [DataMember]
        public string Content { get; set; }
        [DataMember]
        public string Method { get; set; }
        [DataMember]
        public string Uri { get; set; }
        [DataMember]
        public DateTime CreatedAt { get; set; }
    }
}
