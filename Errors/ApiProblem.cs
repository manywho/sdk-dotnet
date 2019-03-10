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
            Kind = ProblemKind.api;
        }

        public ApiProblem(string uri, int statusCode, string message)
            : this()
        {
            Uri = uri;
            StatusCode = statusCode;
            Message = message;
        }

        /// <summary>
        /// The kind of problem
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ProblemKind Kind { get; set; }

        /// <summary>
        /// The URI of the service endpoint the problem originated from
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// The status code returned by the service
        /// </summary>
        [JsonProperty(PropertyName = "statusCode")]
        public int StatusCode { get; set; }

        /// <summary>
        /// The body returned by the service
        /// </summary>
        [JsonProperty(PropertyName = "responseBody")]
        public string ResponseBody { get; set; }

        /// <summary>
        /// A short summary of the error returned by the service
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        [JsonProperty(PropertyName = "responseHeaders")]
        public IDictionary<string, IEnumerable<string>> ResponseHeaders { get; set; }
    }
}
