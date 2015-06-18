using System.Net.Http;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace ManyWho.Flow.SDK.Errors
{
    public class ServiceProblem : ApiProblem
    {
        public ServiceProblem()
            : base()
        {
            this.Kind = ProblemKind.service;
        }

        public ServiceProblem(string uri, int statusCode, string message)
            : base(uri, statusCode, message)
        {
            this.Kind = ProblemKind.service;
        }

        public ServiceProblem(string uri, HttpResponseMessage response, string content)
            : this(uri, (int)response.StatusCode, response.ReasonPhrase)
        {

            this.ResponseHeaders = response.Headers.ToDictionary(header => header.Key, header => header.Value);

            this.ResponseBody = content;

            if (string.IsNullOrWhiteSpace(this.Message))
            {
                this.Message = Regex.Replace(content, @"\t|\n|\r", "");
            }
        }

        [JsonProperty(PropertyName = "invokeType")]
        public string InvokeType { get; set; }
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }
    }
}
