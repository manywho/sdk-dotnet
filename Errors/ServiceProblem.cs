using System;
using Newtonsoft.Json;

namespace ManyWho.Flow.SDK.Errors
{    public class ServiceProblem : ApiProblem
    {
        [JsonProperty(PropertyName = "invokeType")]
        public string InvokeType { get; set; }
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }
    }
}
