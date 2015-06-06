using System;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Service
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ServiceResponseAPI
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public Guid ServiceRequestId { get; set; }
        [DataMember]
        public Guid TenantId { get; set; }
        [DataMember]
        public Guid StateId { get; set; }
        [DataMember]
        public DateTime CreatedAt { get; set; }
    }
}
