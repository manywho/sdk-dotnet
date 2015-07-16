using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ManyWho.Flow.SDK.Errors
{
    public enum ProblemKind
    {
        api,
        service
    }

    public class ApiProblem
    {
        public ApiProblem()
        {
            this.Kind = ProblemKind.api;
        }

        public ApiProblem(string uri, int statusCode, string message)
            : this()
        {
            this.Uri = uri;
            this.StatusCode = statusCode;
            this.Message = message;
        }

        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
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
        public IDictionary<string, IEnumerable<string>> ResponseHeaders { get; set; }
    }
}
