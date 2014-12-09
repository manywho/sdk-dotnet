using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ManyWho.Flow.SDK.Run;
using ManyWho.Flow.SDK.Run.State;
using ManyWho.Flow.SDK.Run.Elements.Config;
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

        public void DispatchStateListenerResponse(INotifier notifier, IAuthenticatedWho authenticatedWho, String callbackUri, ListenerServiceResponseAPI listenerServiceResponse)
        {
            WebException webException = null;
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;

            // We enclose the request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(authenticatedWho, authenticatedWho.ManyWhoTenantId.ToString(), null);

                    // Use the JSON formatter to create the content of the request body
                    httpContent = new StringContent(JsonConvert.SerializeObject(listenerServiceResponse));
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    // Post the authentication request over to ManyWho
                    httpResponseMessage = httpClient.PostAsync(callbackUri, httpContent).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // We successfully executed the request, we can break out of the retry loop
                        break;
                    }
                    else
                    {
                        // Make sure we handle the lack of success properly
                        webException = HttpUtils.HandleUnsuccessfulHttpResponseMessage(notifier, null, i, httpResponseMessage, callbackUri);

                        if (webException != null)
                        {
                            throw webException;
                        }
                    }
                }
                catch (Exception exception)
                {
                    // Make sure we handle the exception properly
                    webException = HttpUtils.HandleHttpException(notifier, null, i, exception, callbackUri);

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
        }

        public IAuthenticatedWho Login(INotifier notifier, String tenantId, String stateId, AuthenticationCredentialsAPI authenticationCredentials)
        {
            WebException webException = null;
            String endpointUrl = null;
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;
            IAuthenticatedWho authenticatedWho = null;
            String authenticationToken = null;

            // We enclose the request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(null, tenantId, stateId);

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

                        // Parse the authentication token into an authentication object
                        authenticatedWho = AuthenticationUtils.Deserialize(Uri.UnescapeDataString(authenticationToken));

                        // We successfully executed the request, we can break out of the retry loop
                        break;
                    }
                    else
                    {
                        // Make sure we handle the lack of success properly
                        webException = HttpUtils.HandleUnsuccessfulHttpResponseMessage(notifier, null, i, httpResponseMessage, endpointUrl);

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

            return authenticatedWho;
        }

        public List<FlowResponseAPI> LoadFlows(INotifier notifier, IAuthenticatedWho authenticatedWho, String tenantId, String filter)
        {
            WebException webException = null;
            String endpointUrl = null;
            HttpClient httpClient = null;
            HttpResponseMessage httpResponseMessage = null;
            List<FlowResponseAPI> flowResponses = null;

            // We enclose the request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(authenticatedWho, tenantId, null);

                    // Construct the URL for the engine execute request
                    endpointUrl = this.ServiceUrl + MANYWHO_ENGINE_LOAD_FLOWS_URI_PART + filter;

                    // Get the flow responses from ManyWho
                    httpResponseMessage = httpClient.GetAsync(endpointUrl).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the flow responses list from the response message
                        flowResponses = JsonConvert.DeserializeObject<List<FlowResponseAPI>>(httpResponseMessage.Content.ReadAsStringAsync().Result);

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

            return flowResponses;
        }

        public FlowResponseAPI LoadFlowById(INotifier notifier, IAuthenticatedWho authenticatedWho, String tenantId, String flowId)
        {
            WebException webException = null;
            String endpointUrl = null;
            HttpClient httpClient = null;
            HttpResponseMessage httpResponseMessage = null;
            FlowResponseAPI flowResponse = null;

            // Check to make sure we have a flow id to pass up to the system
            if (flowId == null ||
                flowId.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.BadRequest, "The identifier for the flow is null or blank.");
            }

            // We enclose the request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(authenticatedWho, tenantId, null);

                    // Construct the URL for the engine execute request
                    endpointUrl = this.ServiceUrl + MANYWHO_ENGINE_LOAD_FLOW_BY_ID_URI_PART + flowId;

                    // Get the flow response from ManyWho
                    httpResponseMessage = httpClient.GetAsync(endpointUrl).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the flow response object from the response message
                        flowResponse = JsonConvert.DeserializeObject<FlowResponseAPI>(httpResponseMessage.Content.ReadAsStringAsync().Result);

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

            return flowResponse;
        }

        public EngineInitializationResponseAPI Initialize(INotifier notifier, IAuthenticatedWho authenticatedWho, String tenantId, EngineInitializationRequestAPI engineInitializationRequest)
        {
            WebException webException = null;
            String endpointUrl = null;
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;
            EngineInitializationResponseAPI engineInitializationResponse = null;

            // We enclose the request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(authenticatedWho, tenantId, null);

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
                    HttpUtils.CleanUpHttp(httpClient, httpContent, httpResponseMessage);
                }
            }

            return engineInitializationResponse;
        }

        public EngineInvokeResponseAPI Execute(INotifier notifier, IAuthenticatedWho authenticatedWho, String tenantId, EngineInvokeRequestAPI engineInvokeRequest)
        {
            WebException webException = null;
            String endpointUrl = null;
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;
            EngineInvokeResponseAPI engineInvokeResponse = null;

            // Make sure we have an engine invoke request object
            if (engineInvokeRequest == null)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.BadRequest, "The EngineInvokeRequest object is null.");
            }

            // Make sure the state identifier has been provided as this is needed for the URI
            if (engineInvokeRequest.stateId == null ||
                engineInvokeRequest.stateId.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.BadRequest, "The EngineInvokeRequest.StateId property is null or blank.");
            }

            // We enclose the execute request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(authenticatedWho, tenantId, engineInvokeRequest.stateId);

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
                    HttpUtils.CleanUpHttp(httpClient, httpContent, httpResponseMessage);
                }
            }

            return engineInvokeResponse;
        }

        public String Response(INotifier notifier, IAuthenticatedWho authenticatedWho, String tenantId, String callbackUri, ServiceResponseAPI serviceResponse)
        {
            WebException webException = null;
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;
            String invokeType = null;

            // Make sure we have a tenant to associate this response with
            if (tenantId == null ||
                tenantId.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.BadRequest, "The TenantId is null or blank.");
            }

            // Make sure we know where we're posting to!
            if (callbackUri == null ||
                callbackUri.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.BadRequest, "The CallbackUri is null or blank.");
            }

            // Make sure we have a service response object
            if (serviceResponse == null)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.BadRequest, "The ServiceResponse object is null.");
            }

            // Make sure the token identifier has been provided as this is needed for the URI
            if (serviceResponse.token == null ||
                serviceResponse.token.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.BadRequest, "The ServiceResponse.Token property is null or blank.");
            }

            // We enclose the execute request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(authenticatedWho, tenantId, null);

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

                        // We successfully executed the request, we can break out of the retry loop
                        break;
                    }
                    else
                    {
                        // Make sure we handle the lack of success properly
                        webException = HttpUtils.HandleUnsuccessfulHttpResponseMessage(notifier, authenticatedWho, i, httpResponseMessage, callbackUri);

                        if (webException != null)
                        {
                            throw webException;
                        }
                    }
                }
                catch (Exception exception)
                {
                    // Make sure we handle the exception properly
                    webException = HttpUtils.HandleHttpException(notifier, null, i, exception, callbackUri);

                    if (webException != null)
                    {
                        throw webException;
                    }
                }
                finally
                {
                    // Clean up the objects from the request
                    HttpUtils.CleanUpHttp(httpClient, httpContent, httpResponseMessage);
                }
            }

            return invokeType;
        }

        public String Event(INotifier notifier, IAuthenticatedWho authenticatedWho, String tenantId, String callbackUri, ListenerServiceResponseAPI listenerServiceResponse)
        {
            WebException webException = null;
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;
            String invokeType = null;

            // Make sure we have a tenant to associate this response with
            if (tenantId == null ||
                tenantId.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.BadRequest, "The TenantId is null or blank.");
            }

            // Make sure we know where we're posting to!
            if (callbackUri == null ||
                callbackUri.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.BadRequest, "The CallbackUri is null or blank.");
            }

            // Make sure we have a listener service response object
            if (listenerServiceResponse == null)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.BadRequest, "The ListenerServiceResponse object is null.");
            }

            // Make sure the token identifier has been provided as this is needed for the URI
            if (listenerServiceResponse.token == null ||
                listenerServiceResponse.token.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.BadRequest, "The ListenerServiceResponse.Token property is null or blank.");
            }

            // We enclose the execute request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(authenticatedWho, tenantId, null);

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

                        // We successfully executed the request, we can break out of the retry loop
                        break;
                    }
                    else
                    {
                        // Make sure we handle the lack of success properly
                        webException = HttpUtils.HandleUnsuccessfulHttpResponseMessage(notifier, authenticatedWho, i, httpResponseMessage, callbackUri);

                        if (webException != null)
                        {
                            throw webException;
                        }
                    }
                }
                catch (Exception exception)
                {
                    // Make sure we handle the exception properly
                    webException = HttpUtils.HandleHttpException(notifier, null, i, exception, callbackUri);

                    if (webException != null)
                    {
                        throw webException;
                    }
                }
                finally
                {
                    // Clean up the objects from the request
                    HttpUtils.CleanUpHttp(httpClient, httpContent, httpResponseMessage);
                }
            }

            return invokeType;
        }

        public EngineNavigationResponseAPI GetNavigation(INotifier notifier, IAuthenticatedWho authenticatedWho, String tenantId, String stateId, EngineNavigationRequestAPI engineNavigationRequest)
        {
            WebException webException = null;
            String endpointUrl = null;
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;
            EngineNavigationResponseAPI engineNavigationResponse = null;

            // Make sure we have an engine navigation request object
            if (engineNavigationRequest == null)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.BadRequest, "The EngineNavigationRequest object is null.");
            }

            // Make sure the state identifier has been provided as this is needed for the URI
            if (engineNavigationRequest.stateId == null ||
                engineNavigationRequest.stateId.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.BadRequest, "The EngineNavigationRequest.StateId property is null or blank.");
            }

            // We enclose the execute request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(authenticatedWho, tenantId, engineNavigationRequest.stateId);

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
                    HttpUtils.CleanUpHttp(httpClient, httpContent, httpResponseMessage);
                }
            }

            return engineNavigationResponse;
        }

        public String ExportState(INotifier notifier, IAuthenticatedWho authenticatedWho, String tenantId, String stateId)
        {
            WebException webException = null;
            String endpointUrl = null;
            HttpClient httpClient = null;
            HttpResponseMessage httpResponseMessage = null;
            String stateJson = null;

            // Check to make sure we have a state id to pass up to the system
            if (stateId == null ||
                stateId.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.BadRequest, "The identifier for the state is null or blank.");
            }

            // We enclose the request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(authenticatedWho, tenantId, null);

                    // Construct the URL for the engine execute request
                    endpointUrl = this.ServiceUrl + MANYWHO_ENGINE_EXPORT_STATE_PACKAGE_URI_PART + stateId;

                    // Get the state package from ManyWho
                    httpResponseMessage = httpClient.GetAsync(endpointUrl).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the state object from the response message
                        stateJson = JsonConvert.DeserializeObject<String>(httpResponseMessage.Content.ReadAsStringAsync().Result);

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

            return stateJson;
        }

        public void ImportState(INotifier notifier, IAuthenticatedWho authenticatedWho, String tenantId, String stateJson)
        {
            WebException webException = null;
            String endpointUrl = null;
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;

            // We enclose the request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(authenticatedWho, tenantId, null);

                    // Use the JSON formatter to create the content of the request body
                    httpContent = new StringContent(stateJson);
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    // Construct the URL for the engine execute request
                    endpointUrl = this.ServiceUrl + MANYWHO_ENGINE_IMPORT_STATE_PACKAGE_URI_PART;

                    // Post the state package to ManyWho
                    httpResponseMessage = httpClient.PostAsync(endpointUrl, httpContent).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
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
        }
    }
}
