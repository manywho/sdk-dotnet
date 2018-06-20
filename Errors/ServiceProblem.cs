using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace ManyWho.Flow.SDK.Errors
{
    public class ServiceProblem : ApiProblem
    {
        public ServiceProblem()
        {
            Kind = ProblemKind.service;
        }

        public ServiceProblem(string uri, HttpStatusCode statusCode, string message)
            : this(uri, (int) statusCode, message)
        {
            
        }

        public ServiceProblem(string uri, int statusCode, string message)
            : base(uri, statusCode, message)
        {
            Kind = ProblemKind.service;
        }

        public ServiceProblem(string uri, HttpResponseMessage response, string content)
            : this(uri, (int)response.StatusCode, response.ReasonPhrase)
        {

            ResponseHeaders = response.Headers.ToDictionary(header => header.Key, header => header.Value);

            ResponseBody = content;

            if (string.IsNullOrWhiteSpace(Message))
            {
                Message = Regex.Replace(content, @"\t|\n|\r", "");
            }
        }

        /// <summary>
        /// The expected invoke type returned by the service
        /// </summary>
        [JsonProperty(PropertyName = "invokeType")]
        public string InvokeType { get; set; }
        
        /// <summary>
        /// The name of the action executed by the service
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }
    }
}
