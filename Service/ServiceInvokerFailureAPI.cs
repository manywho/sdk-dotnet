using System;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Errors;

namespace ManyWho.Flow.SDK.Service
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ServiceInvokerFailureAPI
    {
        /// <summary>
        /// The unique ID of the Failure
        /// </summary>
        [DataMember]
        public Guid Id { get; set; }
        
        /// <summary>
        /// The unique ID of the Request the Failure belongs to
        /// </summary>
        [DataMember]
        public Guid ServiceRequestId { get; set; }
        
        /// <summary>
        /// The unique ID of the tenant the Failure belongs to
        /// </summary>
        [DataMember]
        public Guid TenantId { get; set; }
        
        /// <summary>
        /// The unique ID of the state the Failure belongs to
        /// </summary>
        [DataMember]
        public Guid StateId { get; set; }
        
        /// <summary>
        /// The problem sent back from the service
        /// </summary>
        [DataMember]
        public ServiceProblem Problem { get; set; }
        
        /// <summary>
        /// The date and time that the failure was created and received at
        /// </summary>
        [DataMember]
        public DateTime CreatedAt { get; set; }
    }
}
