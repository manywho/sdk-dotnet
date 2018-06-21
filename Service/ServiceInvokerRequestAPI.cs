using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ManyWho.Flow.SDK.Service
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ServiceInvokerRequestAPI
    {
        /// <summary>
        /// The unique ID of the Request
        /// </summary>
        [DataMember]
        public Guid Id { get; set; }
        
        /// <summary>
        /// The unique ID of the tenant the Request belongs to
        /// </summary>
        [DataMember]
        public Guid TenantId { get; set; }
        
        /// <summary>
        /// The unique ID of the state the Request belongs to
        /// </summary>
        [DataMember]
        public Guid StateId { get; set; }
        
        /// <summary>
        /// The serialised JSON body of the Request sent to the service
        /// </summary>
        [DataMember]
        public string Content { get; set; }
        
        /// <summary>
        /// The HTTP method of the call to the service
        /// </summary>
        [DataMember]
        public string Method { get; set; }
        
        /// <summary>
        /// The URI of the endpoint hit on the service
        /// </summary>
        [DataMember]
        public string Uri { get; set; }
        
        [JsonIgnore]
        public string AuthorizationHeader { get; set; }

        [JsonIgnore]
        public Guid MapElementId { get; set; }

        [JsonIgnore]
        public int SequenceNumber { get; set; }
        
        /// <summary>
        /// The date and time that the request was created and sent at
        /// </summary>
        [DataMember]
        public DateTimeOffset CreatedAt { get; set; }
        
        /// <summary>
        /// A list of responses sent back from the service. This field is only populated when fetching a single Request
        /// </summary>
        [DataMember]
        public List<ServiceInvokerResponseAPI> Responses { get; set; }
        
        /// <summary>
        /// A list of failures sent back from the service. This field is only populated when fetching a single Request
        /// </summary>
        [DataMember]
        public List<ServiceInvokerFailureAPI> Failures { get; set; }
        
        [DataMember]
        public Dictionary<string, object> Attributes { get; set; }
    }
}
