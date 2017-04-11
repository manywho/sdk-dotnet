using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using ManyWho.Flow.SDK.Run;
using ManyWho.Flow.SDK.Run.Elements.Config;
using ManyWho.Flow.SDK.Utils;
using ManyWho.Flow.SDK.Security;
using ManyWho.Flow.SDK.Draw.Flow;
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
    public class RunSingleton
    {
        public const String MANYWHO_BASE_URL = "https://flow.manywho.com";
        public const String MANYWHO_ENGINE_INITIALIZE_URI_PART = "/api/run/1";
        public const String MANYWHO_ENGINE_EXECUTE_URI_PART = "/api/run/1/state/";
        public const String MANYWHO_ENGINE_LOAD_FLOW_BY_ID_URI_PART = "/api/run/1/flow/";
        public const String MANYWHO_ENGINE_LOAD_FLOWS_URI_PART = "/api/run/1/flow?filter=";
        public const String MANYWHO_ENGINE_AUTHENTICATION_URI_PART = "/api/run/1/authentication/";
        public const String MANYWHO_ENGINE_EXPORT_STATE_PACKAGE_URI_PART = "/api/run/1/state/package/";
        public const String MANYWHO_ENGINE_IMPORT_STATE_PACKAGE_URI_PART = "/api/run/1/state/package";
        public const String MANYWHO_ENGINE_GET_NAVIGATION_URI_PART = "/api/run/1/navigation/";

        private static RunSingleton run = null;

        private RunSingleton()
        {

        }

        private String ServiceUrl
        {
            get;
            set;
        }

        public static RunSingleton GetInstance(String serviceUrl)
        {
            if (run == null)
            {
                run = new RunSingleton();
            }

            // Assign the service url to the provided address
            run.ServiceUrl = serviceUrl;

            return run;
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

        public string DispatchStateListenerResponse(INotifier notifier, IAuthenticatedWho authenticatedWho, String callbackUri, ListenerServiceResponseAPI listenerServiceResponse)
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

        public String Login(INotifier notifier, String tenantId, String stateId, AuthenticationCredentialsAPI authenticationCredentials)
        {
            String endpointUrl = null;
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;
            String authenticationToken = null;

            Policy.Handle<ServiceProblemException>().Retry(HttpUtils.MAXIMUM_RETRIES).Execute(() =>
            {
                using (httpClient = HttpUtils.CreateHttpClient(null, tenantId, stateId))
                {
                    // Use the JSON formatter to create the content of the request body
                    httpContent = new StringContent(JsonConvert.SerializeObject(authenticationCredentials));
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    // Construct the URL for the engine execute request
                    endpointUrl = this.ServiceUrl + MANYWHO_ENGINE_AUTHENTICATION_URI_PART + stateId;

                    // Post the authentication request over to ManyWho
                    httpResponseMessage = httpClient.PostAsync(endpointUrl, httpContent).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the authentication token from the response message
                        authenticationToken = JsonConvert.DeserializeObject<String>(httpResponseMessage.Content.ReadAsStringAsync().Result);
                    }
                    else
                    {
                        throw new ServiceProblemException(new ServiceProblem(endpointUrl, httpResponseMessage, string.Empty));
                    }
                }
            });

            return authenticationToken;
        }

        public List<FlowResponseAPI> LoadFlows(INotifier notifier, IAuthenticatedWho authenticatedWho, String tenantId, String filter)
        {
            String endpointUrl = null;
            HttpClient httpClient = null;
            HttpResponseMessage httpResponseMessage = null;
            List<FlowResponseAPI> flowResponses = null;

            Policy.Handle<ServiceProblemException>().Retry(HttpUtils.MAXIMUM_RETRIES).Execute(() =>
            {
                using (httpClient = HttpUtils.CreateHttpClient(authenticatedWho, tenantId, null))
                {
                    // Construct the URL for the engine execute request
                    endpointUrl = this.ServiceUrl + MANYWHO_ENGINE_LOAD_FLOWS_URI_PART + filter;

                    // Get the flow responses from ManyWho
                    httpResponseMessage = httpClient.GetAsync(endpointUrl).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the flow responses list from the response message
                        flowResponses = JsonConvert.DeserializeObject<List<FlowResponseAPI>>(httpResponseMessage.Content.ReadAsStringAsync().Result);
                    }
                    else
                    {
                        throw new ServiceProblemException(new ServiceProblem(endpointUrl, httpResponseMessage, string.Empty));
                    }
                }
            });

            return flowResponses;
        }

        public FlowResponseAPI LoadFlowById(INotifier notifier, String authenticationToken, String tenantId, String flowId)
        {
            String endpointUrl = null;
            HttpClient httpClient = null;
            HttpResponseMessage httpResponseMessage = null;
            FlowResponseAPI flowResponse = null;

            Policy.Handle<ServiceProblemException>().Retry(HttpUtils.MAXIMUM_RETRIES).Execute(() =>
            {
                using (httpClient = HttpUtils.CreateRuntimeHttpClient(authenticationToken, tenantId, null))
                {
                    // Construct the URL for the engine execute request
                    endpointUrl = this.ServiceUrl + MANYWHO_ENGINE_LOAD_FLOW_BY_ID_URI_PART + flowId;

                    // Get the flow response from ManyWho
                    httpResponseMessage = httpClient.GetAsync(endpointUrl).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the flow response object from the response message
                        flowResponse = JsonConvert.DeserializeObject<FlowResponseAPI>(httpResponseMessage.Content.ReadAsStringAsync().Result);
                    }
                    else
                    {
                        throw new ServiceProblemException(new ServiceProblem(endpointUrl, httpResponseMessage, string.Empty));
                    }
                }
            });

            return flowResponse;
        }

        public EngineInitializationResponseAPI Initialize(INotifier notifier, String authenticationToken, String tenantId, EngineInitializationRequestAPI engineInitializationRequest)
        {
            String endpointUrl = null;
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;
            EngineInitializationResponseAPI engineInitializationResponse = null;

            Policy.Handle<ServiceProblemException>().Retry(HttpUtils.MAXIMUM_RETRIES).Execute(() =>
            {
                using (httpClient = HttpUtils.CreateRuntimeHttpClient(authenticationToken, tenantId, null))
                {
                    // Use the JSON formatter to create the content of the request body
                    httpContent = new StringContent(JsonConvert.SerializeObject(engineInitializationRequest));
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    // Construct the URL for the engine initialization request
                    endpointUrl = this.ServiceUrl + MANYWHO_ENGINE_INITIALIZE_URI_PART;

                    // Post the engine initialization request over to ManyWho
                    httpResponseMessage = httpClient.PostAsync(endpointUrl, httpContent).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the engine initialization response object from the response message
                        engineInitializationResponse = JsonConvert.DeserializeObject<EngineInitializationResponseAPI>(httpResponseMessage.Content.ReadAsStringAsync().Result);
                    }
                    else
                    {
                        throw new ServiceProblemException(new ServiceProblem(endpointUrl, httpResponseMessage, string.Empty));
                    }
                }
            });

            return engineInitializationResponse;
        }

        public EngineInvokeResponseAPI Execute(INotifier notifier, String authenticationToken, String tenantId, EngineInvokeRequestAPI engineInvokeRequest)
        {
            String endpointUrl = null;
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;
            EngineInvokeResponseAPI engineInvokeResponse = null;

            Policy.Handle<ServiceProblemException>().Retry(HttpUtils.MAXIMUM_RETRIES).Execute(() =>
            {
                using (httpClient = HttpUtils.CreateRuntimeHttpClient(authenticationToken, tenantId, engineInvokeRequest.stateId))
                {
                    // Use the JSON formatter to create the content of the request body
                    httpContent = new StringContent(JsonConvert.SerializeObject(engineInvokeRequest));
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    // Construct the URL for the engine execute request
                    endpointUrl = this.ServiceUrl + MANYWHO_ENGINE_EXECUTE_URI_PART + engineInvokeRequest.stateId;

                    // Post the engine invoke request over to ManyWho
                    httpResponseMessage = httpClient.PostAsync(endpointUrl, httpContent).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the engine invoke response object from the response message
                        engineInvokeResponse = JsonConvert.DeserializeObject<EngineInvokeResponseAPI>(httpResponseMessage.Content.ReadAsStringAsync().Result);
                    }
                    else
                    {
                        throw new ServiceProblemException(new ServiceProblem(endpointUrl, httpResponseMessage, string.Empty));
                    }
                }
            });

            return engineInvokeResponse;
        }

        public String Response(INotifier notifier, IAuthenticatedWho authenticatedWho, String tenantId, String callbackUri, ServiceResponseAPI serviceResponse)
        {
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;
            String invokeType = null;

            Policy.Handle<ServiceProblemException>().Retry(HttpUtils.MAXIMUM_RETRIES).Execute(() =>
            {
                using (httpClient = HttpUtils.CreateHttpClient(authenticatedWho, tenantId, null))
                {
                    // Use the JSON formatter to create the content of the request body
                    httpContent = new StringContent(JsonConvert.SerializeObject(serviceResponse));
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    // Post the engine invoke request over to ManyWho
                    httpResponseMessage = httpClient.PostAsync(callbackUri, httpContent).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the invoke type from the response message
                        invokeType = httpResponseMessage.Content.ReadAsStringAsync().Result;
                    }
                    else
                    {
                        throw new ServiceProblemException(new ServiceProblem(callbackUri, httpResponseMessage, string.Empty));
                    }
                }
            });

            return invokeType;
        }

        public String Event(INotifier notifier, IAuthenticatedWho authenticatedWho, String tenantId, String callbackUri, ListenerServiceResponseAPI listenerServiceResponse)
        {
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;
            String invokeType = null;

            Policy.Handle<ServiceProblemException>().Retry(HttpUtils.MAXIMUM_RETRIES).Execute(() =>
            {
                using (httpClient = HttpUtils.CreateHttpClient(authenticatedWho, tenantId, null))
                {
                    // Use the JSON formatter to create the content of the request body
                    httpContent = new StringContent(JsonConvert.SerializeObject(listenerServiceResponse));
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    // Post the engine invoke request over to ManyWho
                    httpResponseMessage = httpClient.PostAsync(callbackUri, httpContent).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the invoke type from the response message
                        invokeType = httpResponseMessage.Content.ReadAsStringAsync().Result;
                    }
                    else
                    {
                        throw new ServiceProblemException(new ServiceProblem(callbackUri, httpResponseMessage, string.Empty));
                    }
                }
            });

            return invokeType;
        }

        public EngineNavigationResponseAPI GetNavigation(INotifier notifier, String authenticationToken, String tenantId, String stateId, EngineNavigationRequestAPI engineNavigationRequest)
        {
            String endpointUrl = null;
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;
            EngineNavigationResponseAPI engineNavigationResponse = null;

            Policy.Handle<ServiceProblemException>().Retry(HttpUtils.MAXIMUM_RETRIES).Execute(() =>
            {
                using (httpClient = HttpUtils.CreateRuntimeHttpClient(authenticationToken, tenantId, engineNavigationRequest.stateId))
                {
                    // Use the JSON formatter to create the content of the request body
                    httpContent = new StringContent(JsonConvert.SerializeObject(engineNavigationRequest));
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    // Construct the URL for the engine navigation request
                    endpointUrl = this.ServiceUrl + MANYWHO_ENGINE_GET_NAVIGATION_URI_PART + engineNavigationRequest.stateId;

                    // Post the engine navigation request over to ManyWho
                    httpResponseMessage = httpClient.PostAsync(endpointUrl, httpContent).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the engine navigation response object from the response message
                        engineNavigationResponse = JsonConvert.DeserializeObject<EngineNavigationResponseAPI>(httpResponseMessage.Content.ReadAsStringAsync().Result);
                    }
                    else
                    {
                        throw new ServiceProblemException(new ServiceProblem(endpointUrl, httpResponseMessage, string.Empty));
                    }
                }
            });

            return engineNavigationResponse;
        }

        public String ExportState(INotifier notifier, IAuthenticatedWho authenticatedWho, String tenantId, String stateId)
        {
            String endpointUrl = null;
            HttpClient httpClient = null;
            HttpResponseMessage httpResponseMessage = null;
            String stateJson = null;

            Policy.Handle<ServiceProblemException>().Retry(HttpUtils.MAXIMUM_RETRIES).Execute(() =>
            {
                using (httpClient = HttpUtils.CreateHttpClient(authenticatedWho, tenantId, null))
                {
                    // Construct the URL for the engine execute request
                    endpointUrl = this.ServiceUrl + MANYWHO_ENGINE_EXPORT_STATE_PACKAGE_URI_PART + stateId;

                    // Get the state package from ManyWho
                    httpResponseMessage = httpClient.GetAsync(endpointUrl).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the state object from the response message
                        stateJson = JsonConvert.DeserializeObject<String>(httpResponseMessage.Content.ReadAsStringAsync().Result);
                    }
                    else
                    {
                        throw new ServiceProblemException(new ServiceProblem(endpointUrl, httpResponseMessage, string.Empty));
                    }
                }
            });

            return stateJson;
        }

        public void ImportState(INotifier notifier, IAuthenticatedWho authenticatedWho, String tenantId, String stateJson)
        {
            String endpointUrl = null;
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;

            Policy.Handle<ServiceProblemException>().Retry(HttpUtils.MAXIMUM_RETRIES).Execute(() =>
            {
                using (httpClient = HttpUtils.CreateHttpClient(authenticatedWho, tenantId, null))
                {
                    // Use the JSON formatter to create the content of the request body
                    httpContent = new StringContent(stateJson);
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    // Construct the URL for the engine execute request
                    endpointUrl = this.ServiceUrl + MANYWHO_ENGINE_IMPORT_STATE_PACKAGE_URI_PART;

                    // Post the state package to ManyWho
                    httpResponseMessage = httpClient.PostAsync(endpointUrl, httpContent).Result;

                    // Check the status of the response and respond appropriately
                    if (!httpResponseMessage.IsSuccessStatusCode)
                    {
                        throw new ServiceProblemException(new ServiceProblem(endpointUrl, httpResponseMessage, string.Empty));
                    }
                }
            });
        }
    }
}
