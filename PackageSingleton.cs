using System;
using System.Net.Http;
using Newtonsoft.Json;
using ManyWho.Flow.SDK.Utils;
using ManyWho.Flow.SDK.Security;
using ManyWho.Flow.SDK.Errors;
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
            String endpointUrl = null;
            HttpClient httpClient = null;
            HttpResponseMessage httpResponseMessage = null;
            String flowPackage = null;

            Policy.Handle<ServiceProblemException>().Retry(HttpUtils.MAXIMUM_RETRIES).Execute(() =>
            {
                using (httpClient = HttpUtils.CreateHttpClient(authenticatedWho, tenantId, null))
                {
                    // Construct the URL for the package request
                    endpointUrl = this.ServiceUrl + MANYWHO_PACKAGE_EXPORT_LATEST_FLOW_PACKAGE_URI_PART + flowId;

                    // Get the flow package from ManyWho
                    httpResponseMessage = httpClient.GetAsync(endpointUrl).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the flow package out of the response
                        flowPackage = JsonConvert.DeserializeObject<String>(httpResponseMessage.Content.ReadAsStringAsync().Result);
                    }
                    else
                    {
                        throw new ServiceProblemException(new ServiceProblem(endpointUrl, httpResponseMessage, string.Empty));
                    }
                }
            });

            return flowPackage;
        }
    }
}
