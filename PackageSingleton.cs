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
    public class PackageSingleton
    {
        public const String MANYWHO_BASE_URL = "https://flow.manywho.com";
        public const String MANYWHO_PACKAGE_EXPORT_LATEST_FLOW_PACKAGE_URI_PART = "/api/package/1/flow/";
        public const String MANYWHO_PACKAGE_EXPORT_FLOW_PACKAGE_URI_PART = "/api/package/1/flow/";

        private static PackageSingleton package = null;

        private PackageSingleton()
        {

        }

        private String ServiceUrl
        {
            get;
            set;
        }

        public static PackageSingleton GetInstance(String serviceUrl)
        {
            if (package == null)
            {
                package = new PackageSingleton();
            }

            // Assign the service url to the provided address
            package.ServiceUrl = serviceUrl;

            return package;
        }

        public static PackageSingleton GetInstance()
        {
            if (package == null)
            {
                package = new PackageSingleton();
            }

            // Assign the service url to the default address
            package.ServiceUrl = MANYWHO_BASE_URL;

            return package;
        }

        public String ExportLatestFlowPackage(IAuthenticatedWho authenticatedWho, String tenantId, String flowId, String codeReferenceName, String alertEmail)
        {
            WebException webException = null;
            String endpointUrl = null;
            HttpClient httpClient = null;
            HttpResponseMessage httpResponseMessage = null;
            String flowPackage = null;

            // We enclose the request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(authenticatedWho, tenantId, null);

                    // Construct the URL for the package request
                    endpointUrl = this.ServiceUrl + MANYWHO_PACKAGE_EXPORT_LATEST_FLOW_PACKAGE_URI_PART + flowId;

                    // Get the flow package from ManyWho
                    httpResponseMessage = httpClient.GetAsync(endpointUrl).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the flow package out of the response
                        flowPackage = JsonConvert.DeserializeObject<String>(httpResponseMessage.Content.ReadAsStringAsync().Result);

                        // We successfully executed the request, we can break out of the retry loop
                        break;
                    }
                    else
                    {
                        // Make sure we handle the lack of success properly
                        webException = HttpUtils.HandleUnsuccessfulHttpResponseMessage(authenticatedWho, i, alertEmail, codeReferenceName, httpResponseMessage, endpointUrl);

                        if (webException != null)
                        {
                            throw webException;
                        }
                    }
                }
                catch (Exception exception)
                {
                    // Make sure we handle the exception properly
                    webException = HttpUtils.HandleHttpException(null, i, alertEmail, codeReferenceName, exception, endpointUrl);

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

            return flowPackage;
        }
    }
}
