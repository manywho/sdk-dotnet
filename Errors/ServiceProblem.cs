using System.Net.Http;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

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

            this.ResponseHeaders = (IDictionary<string, IEnumerable<string>>)(from KeyValuePair<string, IEnumerable<string>> header
                                                                                             in response.Headers
                                                                                            select header);

            this.ResponseBody = content;
        }

        [JsonProperty(PropertyName = "invokeType")]
        public string InvokeType { get; set; }
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }
    }
}
