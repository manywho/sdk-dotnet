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
            Exception webException = null;
            TenantResponseAPI responseAPI = null;
            HttpClient httpClient = null;
            HttpResponseMessage httpResponseMessage = null;
            String endpointUrl = null;

            // We enclose the request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(authenticatedWho, authenticatedWho.ManyWhoTenantId.ToString(), null, HttpUtils.SYSTEM_TIMEOUT_SECONDS);

                    // Construct the URL for the tenant request
                    endpointUrl = manywhoBaseUrl + MANYWHO_TENANT_URI_PART_TENANT;

                    // Send the describe request over to the remote service
                    httpResponseMessage = httpClient.GetAsync(endpointUrl).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the tenant response object from the response message
                        responseAPI = JsonConvert.DeserializeObject<TenantResponseAPI>(httpResponseMessage.Content.ReadAsStringAsync().Result);

                        // We successfully executed the request, we can break out of the retry loop
                        break;
                    }
                    else
                    {
                        // Make sure we handle the lack of success properly
                        webException = HttpUtils.HandleUnsuccessfulHttpResponseMessage(notifier, authenticatedWho, i, httpResponseMessage, endpointUrl);

                        if (webException != null)
                        {
                            throw webException;
                        }
                    }
                }
                catch (Exception exception)
                {
                    // Make sure we handle the exception properly
                    webException = HttpUtils.HandleHttpException(notifier, null, i, exception, endpointUrl);

                    if (webException != null)
                    {
                        throw webException;
                    }
                }
                finally
                {
                    // Clean up the objects from the request
                    HttpUtils.CleanUpHttp(httpClient, null, httpResponseMessage);
                }
            }

            return responseAPI;
        }
    }
}
