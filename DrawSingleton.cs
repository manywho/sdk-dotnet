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
using ManyWho.Flow.SDK.Describe;
using ManyWho.Flow.SDK.Security;
using ManyWho.Flow.SDK.Draw.Flow;
using ManyWho.Flow.SDK.Draw.Elements.UI;
using ManyWho.Flow.SDK.Draw.Elements.Map;
using ManyWho.Flow.SDK.Draw.Elements.Type;
using ManyWho.Flow.SDK.Draw.Elements.Group;
using ManyWho.Flow.SDK.Draw.Elements.Config;
using ManyWho.Flow.SDK.Draw.Elements.Value;

namespace ManyWho.Flow.SDK
{
    public class DrawSingleton
    {
        public const String MANYWHO_BASE_URL = "https://flow.manywho.com";

        public const String MANYWHO_DRAW_URI_PART_TYPE_ELEMENT = "/api/draw/1/element/type";
        public const String MANYWHO_DRAW_URI_PART_VALUE_ELEMENT = "/api/draw/1/element/value";
        public const String MANYWHO_DRAW_URI_PART_SERVICE_ELEMENT = "/api/draw/1/element/service";
        public const String MANYWHO_DRAW_URI_PART_PAGE_ELEMENT = "/api/draw/1/element/page";
        public const String MANYWHO_DRAW_URI_PART_MAP_ELEMENT = "/api/draw/1/flow/{0}/{1}/element/map";
        public const String MANYWHO_DRAW_URI_PART_GROUP_ELEMENT = "/api/draw/1/flow/{0}/{1}/element/group";
        public const String MANYWHO_DRAW_URI_PART_FLOW = "/api/draw/1/flow";
        public const String MANYWHO_DRAW_URI_PART_LOGIN = "/api/draw/1/authentication";
        public const String MANYWHO_DRAW_URI_PART_ADD_ELEMENT_TO_FLOW = "/api/draw/1/element/flow/{0}/{1}/{2}";

        public const String MANYWHO_DRAW_URI_PART_ADMIN_PLUGIN_AUTHENTICATION = "/plugins/manywho/api/admin/1/authentication";

        private static DrawSingleton drawSingleton;

        private DrawSingleton()
        {

        }

        public static DrawSingleton GetInstance()
        {
            if (drawSingleton == null)
            {
                drawSingleton = new DrawSingleton();
            }

            return drawSingleton;
        }

        /// <summary>
        /// This method allows you to login as an author of flows.
        /// </summary>
        public IAuthenticatedWho Login(String tenantId, String manywhoBaseUrl, AuthenticationCredentialsAPI authenticationCredentials, String codeReferenceName, String alertEmail)
        {
            WebException webException = null;
            String authorizationToken = null;
            IAuthenticatedWho authenticatedWho = null;
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;
            String endpointUrl = null;

            // We enclose the request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(null, tenantId, null);

                    // Use the JSON formatter to create the content of the request body.
                    httpContent = new StringContent(JsonConvert.SerializeObject(authenticationCredentials));
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    // Construct the URL for the describe request
                    endpointUrl = manywhoBaseUrl + DrawSingleton.MANYWHO_DRAW_URI_PART_LOGIN;

                    // Send the describe request over to the remote service
                    httpResponseMessage = httpClient.PostAsync(endpointUrl, httpContent).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the describe response object from the response message
                        authorizationToken = httpResponseMessage.Content.ReadAsStringAsync().Result;

                        // Trim the quotes from the JSON response token
                        authorizationToken = authorizationToken.Substring(1, authorizationToken.Length - 2);

                        // Deserialize the token back to an authenticated who object
                        authenticatedWho = AuthenticationUtils.Deserialize(Uri.UnescapeDataString(authorizationToken));

                        // We successfully executed the request, we can break out of the retry loop
                        break;
                    }
                    else
                    {
                        // Make sure we handle the lack of success properly
                        webException = HttpUtils.HandleUnsuccessfulHttpResponseMessage(null, i, alertEmail, codeReferenceName, httpResponseMessage, endpointUrl);

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

            return authenticatedWho;
        }

        /// <summary>
        /// This method should be used to get descriptions of supported plugins.
        /// </summary>
        public DescribeServiceResponseAPI Describe(IAuthenticatedWho authenticatedWho, DescribeServiceRequestAPI describeServiceRequest, String codeReferenceName, String alertEmail)
        {
            WebException webException = null;
            DescribeServiceResponseAPI responseAPI = null;
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;
            String endpointUrl = null;

            // We enclose the request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(authenticatedWho, authenticatedWho.ManyWhoTenantId.ToString(), null, HttpUtils.SYSTEM_TIMEOUT_SECONDS);

                    // Use the JSON formatter to create the content of the request body.
                    httpContent = new StringContent(JsonConvert.SerializeObject(describeServiceRequest));
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    // Construct the URL for the describe request
                    endpointUrl = describeServiceRequest.uri + "/metadata";

                    // Send the describe request over to the remote service
                    httpResponseMessage = httpClient.PostAsync(endpointUrl, httpContent).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the describe response object from the response message
                        responseAPI = JsonConvert.DeserializeObject<DescribeServiceResponseAPI>(httpResponseMessage.Content.ReadAsStringAsync().Result);

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

            return responseAPI;
        }

        /// <summary>
        /// This method allows you to save flows back to the service.
        /// </summary>
        public FlowResponseAPI SaveFlow(IAuthenticatedWho authenticatedWho, String manywhoBaseUrl, FlowRequestAPI flowRequest, String codeReferenceName, String alertEmail)
        {
            WebException webException = null;
            FlowResponseAPI flowResponse = null;
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;
            String endpointUrl = null;

            // We enclose the request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(authenticatedWho, authenticatedWho.ManyWhoTenantId.ToString(), null);

                    // Use the JSON formatter to create the content of the request body.
                    httpContent = new StringContent(JsonConvert.SerializeObject(flowRequest));
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    // Construct the URL for the save
                    endpointUrl = manywhoBaseUrl + MANYWHO_DRAW_URI_PART_FLOW;

                    // Send the flow to save over to the service
                    httpResponseMessage = httpClient.PostAsync(endpointUrl, httpContent).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the flow response back from the save
                        flowResponse = JsonConvert.DeserializeObject<FlowResponseAPI>(httpResponseMessage.Content.ReadAsStringAsync().Result);

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

            return flowResponse;
        }

        /// <summary>
        /// This method allows you to save shared elements back to the service.
        /// </summary>
        public void AddElementToFlow(IAuthenticatedWho authenticatedWho, String manywhoBaseUrl, String flowId, String elementType, String elementId, String codeReferenceName, String alertEmail)
        {
            WebException webException = null;
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;
            String endpointUrl = null;

            // We enclose the request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(authenticatedWho, authenticatedWho.ManyWhoTenantId.ToString(), null);

                    // Construct the URL for the save
                    endpointUrl = manywhoBaseUrl + String.Format(MANYWHO_DRAW_URI_PART_ADD_ELEMENT_TO_FLOW, flowId, elementType, elementId);

                    // We construct an empty content request as we don't actually have any post values
                    httpContent = new StringContent("");

                    // Send the request over to the service
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
        }

        /// <summary>
        /// This method allows you to save value elements back to the service.
        /// </summary>
        public ValueElementResponseAPI SaveValueElement(IAuthenticatedWho authenticatedWho, String manywhoBaseUrl, ValueElementRequestAPI valueElementRequest, String codeReferenceName, String alertEmail)
        {
            WebException webException = null;
            ValueElementResponseAPI valueElementResponse = null;
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;
            String endpointUrl = null;

            // We enclose the request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(authenticatedWho, authenticatedWho.ManyWhoTenantId.ToString(), null);

                    // Use the JSON formatter to create the content of the request body.
                    httpContent = new StringContent(JsonConvert.SerializeObject(valueElementRequest));
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    // Construct the URL for the save
                    endpointUrl = manywhoBaseUrl + MANYWHO_DRAW_URI_PART_VALUE_ELEMENT;

                    // Send the value element data to save over to the service
                    httpResponseMessage = httpClient.PostAsync(endpointUrl, httpContent).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the value element response back from the save
                        valueElementResponse = JsonConvert.DeserializeObject<ValueElementResponseAPI>(httpResponseMessage.Content.ReadAsStringAsync().Result);

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

            return valueElementResponse;
        }

        public TypeElementResponseAPI SaveTypeElement(IAuthenticatedWho authenticatedWho, String manywhoBaseUrl, TypeElementRequestAPI typeElementRequest, String codeReferenceName, String alertEmail)
        {
            WebException webException = null;
            TypeElementResponseAPI typeElementResponse = null;
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;
            String endpointUrl = null;

            // We enclose the request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(authenticatedWho, authenticatedWho.ManyWhoTenantId.ToString(), null);

                    // Use the JSON formatter to create the content of the request body.
                    httpContent = new StringContent(JsonConvert.SerializeObject(typeElementRequest));
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    // Construct the URL for the save
                    endpointUrl = manywhoBaseUrl + MANYWHO_DRAW_URI_PART_TYPE_ELEMENT;

                    // Send the type element data to save over to the service
                    httpResponseMessage = httpClient.PostAsync(endpointUrl, httpContent).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the type element response back from the save
                        typeElementResponse = JsonConvert.DeserializeObject<TypeElementResponseAPI>(httpResponseMessage.Content.ReadAsStringAsync().Result);

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

            return typeElementResponse;
        }

        /// <summary>
        /// This method allows you to save service elements back to the service.
        /// </summary>
        public ServiceElementResponseAPI SaveServiceElement(IAuthenticatedWho authenticatedWho, String manywhoBaseUrl, ServiceElementRequestAPI serviceElementRequest, String codeReferenceName, String alertEmail)
        {
            WebException webException = null;
            ServiceElementResponseAPI serviceElementResponse = null;
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;
            String endpointUrl = null;

            // We enclose the request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(authenticatedWho, authenticatedWho.ManyWhoTenantId.ToString(), null);

                    // Use the JSON formatter to create the content of the request body.
                    httpContent = new StringContent(JsonConvert.SerializeObject(serviceElementRequest));
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    // Construct the URL for the save
                    endpointUrl = manywhoBaseUrl + MANYWHO_DRAW_URI_PART_SERVICE_ELEMENT;

                    // Send the service element data to save over to the service
                    httpResponseMessage = httpClient.PostAsync(endpointUrl, httpContent).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the service element response back from the save
                        serviceElementResponse = JsonConvert.DeserializeObject<ServiceElementResponseAPI>(httpResponseMessage.Content.ReadAsStringAsync().Result);

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

            return serviceElementResponse;
        }

        /// <summary>
        /// This method allows you to save page elements back to the service.
        /// </summary>
        public PageElementResponseAPI SavePageElement(IAuthenticatedWho authenticatedWho, String manywhoBaseUrl, PageElementRequestAPI pageElementRequest, String codeReferenceName, String alertEmail)
        {
            WebException webException = null;
            PageElementResponseAPI pageElementResponse = null;
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;
            String endpointUrl = null;

            // We enclose the request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(authenticatedWho, authenticatedWho.ManyWhoTenantId.ToString(), null);

                    // Use the JSON formatter to create the content of the request body.
                    httpContent = new StringContent(JsonConvert.SerializeObject(pageElementRequest));
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    // Construct the URL for the save
                    endpointUrl = manywhoBaseUrl + MANYWHO_DRAW_URI_PART_PAGE_ELEMENT;

                    // Send the page element data to save over to the service
                    httpResponseMessage = httpClient.PostAsync(endpointUrl, httpContent).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the page element response back from the save
                        pageElementResponse = JsonConvert.DeserializeObject<PageElementResponseAPI>(httpResponseMessage.Content.ReadAsStringAsync().Result);

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

            return pageElementResponse;
        }

        public MapElementResponseAPI LoadMapElement(IAuthenticatedWho authenticatedWho, String manywhoBaseUrl, String editingToken, String flowId, String mapElementId, String codeReferenceName, String alertEmail)
        {
            WebException webException = null;
            MapElementResponseAPI mapElementResponse = null;
            HttpClient httpClient = null;
            HttpResponseMessage httpResponseMessage = null;
            String endpointUrl = null;

            // We enclose the request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(authenticatedWho, authenticatedWho.ManyWhoTenantId.ToString(), null);

                    // Construct the URL for the save
                    endpointUrl = manywhoBaseUrl + String.Format(MANYWHO_DRAW_URI_PART_MAP_ELEMENT, flowId, editingToken) + "/" + mapElementId;

                    // Get the map element data to from the service
                    httpResponseMessage = httpClient.GetAsync(endpointUrl).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the map element response back from the load request
                        mapElementResponse = JsonConvert.DeserializeObject<MapElementResponseAPI>(httpResponseMessage.Content.ReadAsStringAsync().Result);

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

            return mapElementResponse;
        }

        public MapElementResponseAPI SaveMapElement(IAuthenticatedWho authenticatedWho, String manywhoBaseUrl, String editingToken, String flowId, MapElementRequestAPI mapElementRequest, String codeReferenceName, String alertEmail)
        {
            WebException webException = null;
            MapElementResponseAPI mapElementResponse = null;
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;
            String endpointUrl = null;

            // We enclose the request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(authenticatedWho, authenticatedWho.ManyWhoTenantId.ToString(), null);

                    // Use the JSON formatter to create the content of the request body.
                    httpContent = new StringContent(JsonConvert.SerializeObject(mapElementRequest));
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    // Construct the URL for the save
                    endpointUrl = manywhoBaseUrl + String.Format(MANYWHO_DRAW_URI_PART_MAP_ELEMENT, flowId, editingToken);

                    // Send the map element data to save over to the service
                    httpResponseMessage = httpClient.PostAsync(endpointUrl, httpContent).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the map element response back from the save
                        mapElementResponse = JsonConvert.DeserializeObject<MapElementResponseAPI>(httpResponseMessage.Content.ReadAsStringAsync().Result);

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

            return mapElementResponse;
        }

        public GroupElementResponseAPI LoadGroupElement(IAuthenticatedWho authenticatedWho, String manywhoBaseUrl, String editingToken, String flowId, String groupElementId, String codeReferenceName, String alertEmail)
        {
            WebException webException = null;
            GroupElementResponseAPI groupElementResponse = null;
            HttpClient httpClient = null;
            HttpResponseMessage httpResponseMessage = null;
            String endpointUrl = null;

            // We enclose the request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(authenticatedWho, authenticatedWho.ManyWhoTenantId.ToString(), null);

                    // Construct the URL for the save
                    endpointUrl = manywhoBaseUrl + String.Format(MANYWHO_DRAW_URI_PART_GROUP_ELEMENT, flowId, editingToken) + "/" + groupElementId;

                    // Get the group element data to from the service
                    httpResponseMessage = httpClient.GetAsync(endpointUrl).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the group element response back from the load request
                        groupElementResponse = JsonConvert.DeserializeObject<GroupElementResponseAPI>(httpResponseMessage.Content.ReadAsStringAsync().Result);

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

            return groupElementResponse;
        }

        public GroupElementResponseAPI SaveGroupElement(IAuthenticatedWho authenticatedWho, String manywhoBaseUrl, String editingToken, String flowId, GroupElementRequestAPI groupElementRequest, String codeReferenceName, String alertEmail)
        {
            WebException webException = null;
            GroupElementResponseAPI groupElementResponse = null;
            HttpClient httpClient = null;
            HttpContent httpContent = null;
            HttpResponseMessage httpResponseMessage = null;
            String endpointUrl = null;

            // We enclose the request in a for loop to handle http errors
            for (int i = 0; i < HttpUtils.MAXIMUM_RETRIES; i++)
            {
                try
                {
                    // Create the http client to handle our request
                    httpClient = HttpUtils.CreateHttpClient(authenticatedWho, authenticatedWho.ManyWhoTenantId.ToString(), null);

                    // Use the JSON formatter to create the content of the request body.
                    httpContent = new StringContent(JsonConvert.SerializeObject(groupElementRequest));
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    // Construct the URL for the save
                    endpointUrl = manywhoBaseUrl + String.Format(MANYWHO_DRAW_URI_PART_GROUP_ELEMENT, flowId, editingToken);

                    // Send the group element data to save over to the service
                    httpResponseMessage = httpClient.PostAsync(endpointUrl, httpContent).Result;

                    // Check the status of the response and respond appropriately
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        // Get the group element response back from the save
                        groupElementResponse = JsonConvert.DeserializeObject<GroupElementResponseAPI>(httpResponseMessage.Content.ReadAsStringAsync().Result);

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

            return groupElementResponse;
        }
    }
}
