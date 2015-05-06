using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ManyWho.Flow.SDK.Errors
{
    public enum ProblemKind
    {
        api,
        service
    }

    public class ApiProblem
    {
        [JsonProperty(PropertyName = "kind")]
        public ProblemKind Kind { get; set; }
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
        [JsonProperty(PropertyName = "statusCode")]
        public int StatusCode { get; set; }
        [JsonProperty(PropertyName = "responseBody")]
        public string ResponseBody { get; set; }
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        [JsonProperty(PropertyName = "responseHeaders")]
        public Dictionary<string, IEnumerable<string>> ResponseHeaders { get; set; }
    }
}
