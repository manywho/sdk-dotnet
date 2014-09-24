using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ManyWho.Flow.SDK.Translate;
using ManyWho.Flow.SDK.Utils;
using ManyWho.Flow.SDK.Security;
using ManyWho.Flow.SDK.Draw.Flow;

/*!

Copyright 2013 Manywho, Inc.

Licensed under the Manywho License, Version 1.0 (the "License"); you may not use this
file except in compliance with the License.

You may obtain a copy of the License at: http://manywho.com/sharedsource

Unless required by applicable law or agreed to in writing, software distributed under
the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the specific language governing
permissions and limitations under the License.

*/

namespace ManyWho.Flow.SDK
{
    public class TranslateSingleton
    {
        public const String MANYWHO_BASE_URL = "https://flow.manywho.com";
        public const String MANYWHO_PACKAGE_GET_CONTENT_VALUE_CULTURES_URI_PART = "/api/translate/1/culture";

        private static TranslateSingleton translate = null;

        private TranslateSingleton()
        {

        }

        private String ServiceUrl
        {
            get;
            set;
        }

        public static TranslateSingleton GetInstance(String serviceUrl)
        {
            if (translate == null)
            {
                translate = new TranslateSingleton();
            }

            // Assign the service url to the provided address
            translate.ServiceUrl = serviceUrl;

            return translate;
        }

        public static TranslateSingleton GetInstance()
        {
            if (translate == null)
            {
                translate = new TranslateSingleton();
            }

            // Assign the service url to the default address
            translate.ServiceUrl = MANYWHO_BASE_URL;

            return translate;
        }

        public List<CultureAPI> GetCultures(INotifier notifier, IAuthenticatedWho authenticatedWho, String tenantId)
        {
            WebException webException = null;
            String endpointUrl = null;
            HttpClient httpClient = null;
            HttpResponseMessage httpResponseMessage = null;
            List<CultureAPI> cultures = null;

            // We enclose the request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(authenticatedWho, tenantId, null);

                    // Construct the URL for the content value culture request
                    endpointUrl = this.ServiceUrl + MANYWHO_PACKAGE_GET_CONTENT_VALUE_CULTURES_URI_PART;

                    // Get the content value cultures from ManyWho
                    httpResponseMessage = httpClient.GetAsync(endpointUrl).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the list of content value cultures from the service
                        cultures = JsonConvert.DeserializeObject<List<CultureAPI>>(httpResponseMessage.Content.ReadAsStringAsync().Result);

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

            return cultures;
        }
    }
}
