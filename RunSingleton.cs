using System;
using System.Net.Http;
using System.Net.Http.Headers;
using ManyWho.Flow.SDK.Errors;
using ManyWho.Flow.SDK.Run.Elements.Config;
using ManyWho.Flow.SDK.Security;
using ManyWho.Flow.SDK.Utils;
using Newtonsoft.Json;
using Polly;

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
    public class RunSingleton
    {
        public const string MANYWHO_BASE_URL = "https://flow.manywho.com";

        private static RunSingleton run;

        private RunSingleton()
        {

        }

        private string ServiceUrl
        {
            get;
            set;
        }

        public static RunSingleton GetInstance()
        {
            if (run == null)
            {
                run = new RunSingleton();
            }

            // Assign the service url to the default address
            run.ServiceUrl = MANYWHO_BASE_URL;

            return run;
        }

        public string DispatchStateListenerResponse(IAuthenticatedWho authenticatedWho, string callbackUri, ListenerServiceResponseAPI listenerServiceResponse)
        {
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;
            string invokeResponse = null;

            Policy.Handle<ServiceProblemException>().Retry(HttpUtils.MAXIMUM_RETRIES).Execute(() =>
            {
                using (httpClient = HttpUtils.CreateHttpClient(authenticatedWho, authenticatedWho.ManyWhoTenantId.ToString(), null))
                {
                    // Use the JSON formatter to create the content of the request body
                    httpContent = new StringContent(JsonConvert.SerializeObject(listenerServiceResponse));
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    // Post the authentication request over to ManyWho
                    httpResponseMessage = httpClient.PostAsync(callbackUri, httpContent).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        invokeResponse = JsonConvert.DeserializeObject<string>(httpResponseMessage.Content.ReadAsStringAsync().Result);
                    }
                    else
                    {
                        throw new ServiceProblemException(new ServiceProblem(callbackUri, httpResponseMessage, string.Empty));
                    }
                }
            });

            return invokeResponse;
        }
    }
}
