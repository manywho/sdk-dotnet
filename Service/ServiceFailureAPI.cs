using System;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Errors;

namespace ManyWho.Flow.SDK.Service
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ServiceFailureAPI
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
        public ServiceProblem Problem { get; set; }
        [DataMember]
        public DateTime CreatedAt { get; set; }
    }
}
