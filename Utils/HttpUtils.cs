using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using ManyWho.Flow.SDK.Security;

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

namespace ManyWho.Flow.SDK.Utils
{
    public class HttpUtils
    {
        public const Int32 MAXIMUM_RETRIES = 3;
        public const Int32 TIMEOUT_SECONDS = 20;
        public const Int32 SYSTEM_TIMEOUT_SECONDS = 500;

        public const String HEADER_AUTHORIZATION = "Authorization";
        public const String HEADER_MANYWHO_STATE = "ManyWhoState";
        public const String HEADER_MANYWHO_TENANT = "ManyWhoTenant";
        public const String HEADER_CULTURE = "Culture";

        public static HttpResponseException HandleUnsuccessfulHttpResponseMessage(IAuthenticatedWho authenticatedWho, Int32 iteration, String alertEmail, String codeReferenceName, HttpResponseMessage httpResponseMessage, String endpointUrl)
        {
            HttpResponseException httpResponseException = null;

            if (iteration >= (MAXIMUM_RETRIES - 1))
            {
                // The the alert email the fault
                ErrorUtils.SendAlert(authenticatedWho, "Fault", alertEmail, codeReferenceName, "The system has attempted multiple retries (" + MAXIMUM_RETRIES + ") with no luck on: " + endpointUrl + ". The status code is: " + httpResponseMessage.StatusCode + ". The reason is: " + httpResponseMessage.ReasonPhrase);

                // Throw the fault up to the caller
                httpResponseException = ErrorUtils.GetWebException(httpResponseMessage.StatusCode, httpResponseMessage.ReasonPhrase);
            }
            else
            {
                // Alert the admin that a retry has happened
                ErrorUtils.SendAlert(authenticatedWho, "Warning", alertEmail, codeReferenceName, "The system is attempting a retry (" + iteration + ") on: " + endpointUrl + ". The status code is: " + httpResponseMessage.StatusCode + ". The reason is: " + httpResponseMessage.ReasonPhrase);
            }

            return httpResponseException;
        }

        public static HttpResponseException HandleHttpException(IAuthenticatedWho authenticatedWho, Int32 iteration, String alertEmail, String codeReferenceName, Exception exception, String endpointUrl)
        {
            HttpResponseException httpResponseException = null;

            if (iteration >= (MAXIMUM_RETRIES - 1))
            {
                // The the alert email the fault
                ErrorUtils.SendAlert(authenticatedWho, "Fault", alertEmail, codeReferenceName, "The system has attempted multiple retries (" + MAXIMUM_RETRIES + ") with no luck on: " + endpointUrl + ". The error message we're getting back is: " + ErrorUtils.GetExceptionMessage(exception));

                // Throw the fault up to the caller
                httpResponseException = ErrorUtils.GetWebException(HttpStatusCode.BadRequest, exception);
            }
            else
            {
                // Alert the admin that a retry has happened
                ErrorUtils.SendAlert(authenticatedWho, "Warning", alertEmail, codeReferenceName, "The system is attempting a retry (" + iteration + ") on: " + endpointUrl + ". The error message we're getting back is: " + ErrorUtils.GetExceptionMessage(exception));
            }

            return httpResponseException;
        }

        public static HttpClient CreateHttpClient(IAuthenticatedWho authenticatedWho, String tenantId, String stateId)
        {
            return CreateHttpClient(authenticatedWho, tenantId, stateId, TIMEOUT_SECONDS);
        }

        public static HttpClient CreateHttpClient(IAuthenticatedWho authenticatedWho, String tenantId, String stateId, Int32 timeOut)
        {
            HttpClient httpClient = null;

            httpClient = new HttpClient();

            if (authenticatedWho != null)
            {
                // Serialize and add the user information to the header
                httpClient.DefaultRequestHeaders.Add(HEADER_AUTHORIZATION, HttpUtility.UrlEncode(AuthenticationUtils.Serialize(authenticatedWho)));
            }

            if (tenantId != null &&
                tenantId.Trim().Length > 0)
            {
                // Add the tenant to the header
                httpClient.DefaultRequestHeaders.Add(HEADER_MANYWHO_TENANT, tenantId);
            }

            if (stateId != null &&
                stateId.Trim().Length > 0)
            {
                // Add the state to the header
                httpClient.DefaultRequestHeaders.Add(HEADER_MANYWHO_STATE, stateId);
            }

            // Set the timeout for the request
            httpClient.Timeout = TimeSpan.FromSeconds(timeOut);

            return httpClient;
        }

        public static void CleanUpHttp(HttpClient httpClient, HttpContent httpContent, HttpResponseMessage httpResponseMessage)
        {
            if (httpClient != null)
            {
                httpClient.Dispose();
                httpClient = null;
            }

            if (httpContent != null)
            {
                httpContent.Dispose();
                httpContent = null;
            }

            if (httpResponseMessage != null)
            {
                httpResponseMessage.Dispose();
                httpResponseMessage = null;
            }
        }
    }
}
