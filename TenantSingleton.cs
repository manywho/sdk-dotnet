using System;
using System.Net.Http;
using Newtonsoft.Json;
using ManyWho.Flow.SDK.Errors;
using ManyWho.Flow.SDK.Utils;
using ManyWho.Flow.SDK.Tenant;
using ManyWho.Flow.SDK.Security;
using Polly;

namespace ManyWho.Flow.SDK
{
    public class TenantSingleton
    {
        public const String MANYWHO_BASE_URL = "https://flow.manywho.com";

        public const String MANYWHO_TENANT_URI_PART_TENANT = "/api/admin/1/tenant";

        private static TenantSingleton tenantSingleton;

        private TenantSingleton()
        {

        }

        public static TenantSingleton GetInstance()
        {
            if (tenantSingleton == null)
            {
                tenantSingleton = new TenantSingleton();
            }

            return tenantSingleton;
        }

        /// <summary>
        /// This method should be used to get descriptions of supported plugins.
        /// </summary>
        public TenantResponseAPI GetTenant(INotifier notifier, IAuthenticatedWho authenticatedWho, String manywhoBaseUrl)
        {
            TenantResponseAPI responseAPI = null;
            HttpClient httpClient = null;
            HttpResponseMessage httpResponseMessage = null;
            String endpointUrl = null;

            Policy.Handle<ServiceProblemException>().Retry(HttpUtils.MAXIMUM_RETRIES).Execute(() =>
            {
                using (httpClient = HttpUtils.CreateHttpClient(authenticatedWho, authenticatedWho.ManyWhoTenantId.ToString(), null, HttpUtils.SYSTEM_TIMEOUT_SECONDS))
                {
                    // Construct the URL for the tenant request
                    endpointUrl = manywhoBaseUrl + MANYWHO_TENANT_URI_PART_TENANT;

                    // Send the describe request over to the remote service
                    httpResponseMessage = httpClient.GetAsync(endpointUrl).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the tenant response object from the response message
                        responseAPI = JsonConvert.DeserializeObject<TenantResponseAPI>(httpResponseMessage.Content.ReadAsStringAsync().Result);
                    }
                    else
                    {
                        throw new ServiceProblemException(new ServiceProblem(endpointUrl, httpResponseMessage, string.Empty));
                    }
                }
            });

            return responseAPI;
        }
    }
}
