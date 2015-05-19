using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using ManyWho.Flow.SDK.Utils;
using ManyWho.Flow.SDK.Run.State;
using ManyWho.Flow.SDK.Errors;
using Polly;

namespace ManyWho.Flow.SDK
{
    public class ReportSingleton
    {
        public const string MANYWHO_REPORT_BASE_URL = "https://report.manywho.com";
        public const string MANYWHO_REPORT_URI_PART_STATES = "/api/report/1/states";
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

        public void SendStateToReportingService(string reportBaseUrl, List<StateAPI> states)
        {
            HttpResponseMessage httpResponseMessage = null;
            HttpContent httpContent = null;
            HttpClient httpClient = null;

            if (string.IsNullOrWhiteSpace(reportBaseUrl) == true)
            {
                // Assign to the standard URL
                reportBaseUrl = MANYWHO_REPORT_BASE_URL;
            }

            Policy.Handle<ServiceProblemException>().Retry(HttpUtils.MAXIMUM_RETRIES).Execute(() =>
            {
                using (httpClient = new HttpClient())
                {
                    httpClient.Timeout = TimeSpan.FromSeconds(HttpUtils.TIMEOUT_SECONDS_FOR_USER_INTERACTIONS);

                    // Use the JSON formatter to create the content of the request body.
                    httpContent = new StringContent(JsonConvert.SerializeObject(states));
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    // Construct the full url
                    reportBaseUrl = reportBaseUrl + MANYWHO_REPORT_URI_PART_STATES;

                    // Post the content over to the report service
                    httpResponseMessage = httpClient.PostAsync(reportBaseUrl, httpContent).Result;

                    if (!httpResponseMessage.IsSuccessStatusCode)
                    {
                        throw new ServiceProblemException(new ServiceProblem(MANYWHO_REPORT_URI_PART_STATES, httpResponseMessage, httpResponseMessage.ReasonPhrase));
                    }
                }
            });
        }
    }
}
