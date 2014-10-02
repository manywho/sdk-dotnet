using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ManyWho.Flow.SDK.Utils;
using ManyWho.Flow.SDK.Tenant;
using ManyWho.Flow.SDK.Security;
using ManyWho.Flow.SDK.Run.State;

namespace ManyWho.Flow.SDK
{
    public class ReportSingleton
    {
        public const String MANYWHO_REPORT_BASE_URL = "https://report.manywho.com";

        public const String MANYWHO_REPORT_URI_PART_STATES = "/api/report/1/states";

        private static ReportSingleton reportSingleton;

        private ReportSingleton()
        {

        }

        public static ReportSingleton GetInstance()
        {
            if (reportSingleton == null)
            {
                reportSingleton = new ReportSingleton();
            }

            return reportSingleton;
        }

        public void SendStateToReportingService(String reportBaseUrl, List<StateAPI> states)
        {
            HttpResponseMessage httpResponseMessage = null;
            HttpContent httpContent = null;
            HttpClient httpClient = null;
            String reportResult = null;

            if (String.IsNullOrWhiteSpace(reportBaseUrl) == true)
            {
                // Assign to the standard URL
                reportBaseUrl = MANYWHO_REPORT_BASE_URL;
            }

            for (int i = 0; i < HttpRetryHelper.MAXIMUM_RETRIES; i++)
            {
                httpClient = new HttpClient();
                httpClient.Timeout = TimeSpan.FromSeconds(HttpRetryHelper.TIMEOUT_SECONDS_FOR_USER_INTERACTIONS);

                // Use the JSON formatter to create the content of the request body.
                httpContent = new StringContent(JsonConvert.SerializeObject(states));
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                // Construct the full url
                reportBaseUrl = reportBaseUrl + MANYWHO_REPORT_URI_PART_STATES;

                // Post the content over to the report service
                httpResponseMessage = httpClient.PostAsync(reportBaseUrl, httpContent).Result;

                if (httpResponseMessage.IsSuccessStatusCode)
                {
                    reportResult = httpResponseMessage.Content.ReadAsStringAsync().Result;

                    break;
                }
                else
                {
                    if (i >= (HttpRetryHelper.MAXIMUM_RETRIES - 1))
                    {
                        throw new ArgumentNullException(httpResponseMessage.StatusCode.ToString(), httpResponseMessage.ReasonPhrase);
                    }
                }
            }
        }
    }
}
