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

namespace ManyWho.Flow.SDK.Utils
{
    public class HttpUtils
    {
        public const Int32 MAXIMUM_RETRIES = 3;
        public const Int32 TIMEOUT_SECONDS = 20;

        public const String HEADER_AUTHORIZATION = "Authorization";
        public const String HEADER_MANYWHO_STATE = "ManyWhoState";
        public const String HEADER_MANYWHO_TENANT = "ManyWhoTenant";

        public static void HandleUnsuccessfulHttpResponseMessage(IAuthenticatedWho authenticatedWho, Int32 iteration, String alertEmail, String codeReferenceName, HttpResponseMessage httpResponseMessage, String endpointUrl)
        {
            if (iteration >= (MAXIMUM_RETRIES - 1))
            {
                // The the alert email the fault
                ErrorUtils.SendAlert(authenticatedWho, "Fault", alertEmail, codeReferenceName, "The system has attempted multiple retries (" + MAXIMUM_RETRIES + ") with no luck on: " + endpointUrl + ". The status code is: " + httpResponseMessage.StatusCode + ". The reason is: " + httpResponseMessage.ReasonPhrase);

                // Throw the fault up to the caller
                throw ErrorUtils.GetWebException(httpResponseMessage.StatusCode, httpResponseMessage.ReasonPhrase);
            }
            else
            {
                // Alert the admin that a retry has happened
                ErrorUtils.SendAlert(authenticatedWho, "Warning", alertEmail, codeReferenceName, "The system is attempting a retry (" + iteration + ") on: " + endpointUrl + ". The status code is: " + httpResponseMessage.StatusCode + ". The reason is: " + httpResponseMessage.ReasonPhrase);
            }
        }

        public static void HandleHttpException(IAuthenticatedWho authenticatedWho, Int32 iteration, String alertEmail, String codeReferenceName, Exception exception, String endpointUrl)
        {
            if (iteration >= (MAXIMUM_RETRIES - 1))
            {
                // The the alert email the fault
                ErrorUtils.SendAlert(authenticatedWho, "Fault", alertEmail, codeReferenceName, "The system has attempted multiple retries (" + MAXIMUM_RETRIES + ") with no luck on: " + endpointUrl + ". The error message we're getting back is: " + exception.Message);

                // Throw the fault up to the caller
                throw ErrorUtils.GetWebException(HttpStatusCode.BadRequest, exception.Message);
            }
            else
            {
                // Alert the admin that a retry has happened
                ErrorUtils.SendAlert(authenticatedWho, "Warning", alertEmail, codeReferenceName, "The system is attempting a retry (" + iteration + ") on: " + endpointUrl + ". The error message we're getting back is: " + exception.Message);
            }
        }

        public static HttpClient CreateHttpClient(IAuthenticatedWho authenticatedWho, String tenantId, String stateId)
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
            httpClient.Timeout = TimeSpan.FromSeconds(TIMEOUT_SECONDS);

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
