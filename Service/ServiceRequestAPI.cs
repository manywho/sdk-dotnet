using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

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
        [JsonIgnore]
        public string AuthorizationHeader { get; set; }
        [DataMember]
        public DateTime CreatedAt { get; set; }
        [DataMember]
        public List<ServiceResponseAPI> Responses { get; set; }
        [DataMember]
        public List<ServiceFailureAPI> Failures { get; set; }
        [DataMember]
        public Dictionary<string, object> Attributes { get; set; }
    }
}
