using System;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Service
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ServiceInvokerResponseAPI
    {
        /// <summary>
        /// The unique ID of the Response
        /// </summary>
        [DataMember]
        public Guid Id { get; set; }
        
        /// <summary>
        /// The unique ID of the Request the Response belongs to
        /// </summary>
        [DataMember]
        public Guid ServiceRequestId { get; set; }
        
        /// <summary>
        /// The unique ID the tenant the Response belongs to
        /// </summary>
        [DataMember]
        public Guid TenantId { get; set; }
        
        /// <summary>
        /// The unique ID of the state the Response belongs to
        /// </summary>
        [DataMember]
        public Guid StateId { get; set; }
        
        /// <summary>
        /// The date and time that the response was created and received at
        /// </summary>
        [DataMember]
        public DateTime CreatedAt { get; set; }
        
        /// <summary>
        /// The serialised body of the Response sent back from the service
        /// </summary>
        [DataMember]
        public string Content { get; set; }
    }
}
