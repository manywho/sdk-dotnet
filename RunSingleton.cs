using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using ManyWho.Flow.SDK.Run;
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
        public const String MANYWHO_ENGINE_LOAD_FLOW_BY_ID_URI_PART = "api/run/1/flow/";

        private static RunSingleton run = null;

        private RunSingleton()
        {

        }

        public static RunSingleton GetInstance()
        {
            if (run == null)
            {
                run = new RunSingleton();
            }

            return run;
        }

        public FlowResponseAPI LoadFlowById(IAuthenticatedWho authenticatedWho, String tenantId, String flowId, String codeReferenceName, String alertEmail)
        {
            String endpointUrl = null;
            HttpClient httpClient = null;
            HttpResponseMessage httpResponseMessage = null;
            FlowResponseAPI flowResponse = null;

            // Check to make sure we have a flow id to pass up to the system
            if (flowId == null ||
                flowId.Trim().Length > 0)
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
                    endpointUrl = MANYWHO_BASE_URL + MANYWHO_ENGINE_LOAD_FLOW_BY_ID_URI_PART + flowId;

                    // Get the flow response from ManyWho
                    httpResponseMessage = httpClient.GetAsync(endpointUrl).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the flow response object from the response message
                        flowResponse = httpResponseMessage.Content.ReadAsAsync<FlowResponseAPI>().Result;

                        // We successfully executed the request, we can break out of the retry loop
                        break;
                    }
                    else
                    {
                        // Make sure we handle the lack of success properly
                        HttpUtils.HandleUnsuccessfulHttpResponseMessage(authenticatedWho, i, alertEmail, codeReferenceName, httpResponseMessage, endpointUrl);
                    }
                }
                catch (Exception exception)
                {
                    // Make sure we handle the exception properly
                    HttpUtils.HandleHttpException(authenticatedWho, i, alertEmail, codeReferenceName, exception, endpointUrl);
                }
                finally
                {
                    // Clean up the objects from the request
                    HttpUtils.CleanUpHttp(httpClient, null, httpResponseMessage);
                }
            }

            return flowResponse;
        }

        public EngineInitializationResponseAPI Initialize(IAuthenticatedWho authenticatedWho, String tenantId, EngineInitializationRequestAPI engineInitializationRequest, String codeReferenceName, String alertEmail)
        {
            String endpointUrl = null;
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;
            MediaTypeFormatter jsonMediaTypeFormatter = null;
            EngineInitializationResponseAPI engineInitializationResponse = null;

            // We enclose the request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(authenticatedWho, tenantId, null);

                    // Create a new json formatter so the request will be in the right format
                    jsonMediaTypeFormatter = new JsonMediaTypeFormatter();

                    // Use the JSON formatter to create the content of the request body
                    httpContent = new ObjectContent<EngineInitializationRequestAPI>(engineInitializationRequest, jsonMediaTypeFormatter);

                    // Construct the URL for the engine initialization request
                    endpointUrl = MANYWHO_BASE_URL + MANYWHO_ENGINE_INITIALIZE_URI_PART;

                    // Post the engine initialization request over to ManyWho
                    httpResponseMessage = httpClient.PostAsync(endpointUrl, httpContent).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the engine initialization response object from the response message
                        engineInitializationResponse = httpResponseMessage.Content.ReadAsAsync<EngineInitializationResponseAPI>().Result;

                        // We successfully executed the request, we can break out of the retry loop
                        break;
                    }
                    else
                    {
                        // Make sure we handle the lack of success properly
                        HttpUtils.HandleUnsuccessfulHttpResponseMessage(authenticatedWho, i, alertEmail, codeReferenceName, httpResponseMessage, endpointUrl);
                    }
                }
                catch (Exception exception)
                {
                    // Make sure we handle the exception properly
                    HttpUtils.HandleHttpException(authenticatedWho, i, alertEmail, codeReferenceName, exception, endpointUrl);
                }
                finally
                {
                    // Clean up the objects from the request
                    HttpUtils.CleanUpHttp(httpClient, httpContent, httpResponseMessage);
                }
            }

            return engineInitializationResponse;
        }

        public EngineInvokeResponseAPI Execute(IAuthenticatedWho authenticatedWho, String tenantId, EngineInvokeRequestAPI engineInvokeRequest, String codeReferenceName, String alertEmail)
        {
            String endpointUrl = null;
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;
            MediaTypeFormatter jsonMediaTypeFormatter = null;
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

                    // Create a new json formatter so the request will be in the right format
                    jsonMediaTypeFormatter = new JsonMediaTypeFormatter();

                    // Use the JSON formatter to create the content of the request body
                    httpContent = new ObjectContent<EngineInvokeRequestAPI>(engineInvokeRequest, jsonMediaTypeFormatter);

                    // Construct the URL for the engine execute request
                    endpointUrl = MANYWHO_BASE_URL + MANYWHO_ENGINE_EXECUTE_URI_PART + engineInvokeRequest.stateId;

                    // Post the engine invoke request over to ManyWho
                    httpResponseMessage = httpClient.PostAsync(endpointUrl, httpContent).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the engine invoke response object from the response message
                        engineInvokeResponse = httpResponseMessage.Content.ReadAsAsync<EngineInvokeResponseAPI>().Result;

                        // We successfully executed the request, we can break out of the retry loop
                        break;
                    }
                    else
                    {
                        // Make sure we handle the lack of success properly
                        HttpUtils.HandleUnsuccessfulHttpResponseMessage(authenticatedWho, i, alertEmail, codeReferenceName, httpResponseMessage, endpointUrl);
                    }
                }
                catch (Exception exception)
                {
                    // Make sure we handle the exception properly
                    HttpUtils.HandleHttpException(authenticatedWho, i, alertEmail, codeReferenceName, exception, endpointUrl);
                }
                finally
                {
                    // Clean up the objects from the request
                    HttpUtils.CleanUpHttp(httpClient, httpContent, httpResponseMessage);
                }
            }

            return engineInvokeResponse;
        }
    }
}
