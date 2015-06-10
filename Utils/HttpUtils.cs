using System;
//using System.Text;
using System.Net;
using System.Net.Http;
//using System.Threading.Tasks;
using ManyWho.Flow.SDK.Security;

///*!
//Copyright 2013 Manywho, Inc.

//Licensed under the Manywho License, Version 1.0 (the "License"); you may not use this
//file except in compliance with the License.

//You may obtain a copy of the License at: http://manywho.com/sharedsource

//Unless required by applicable law or agreed to in writing, software distributed under
//the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
//KIND, either express or implied. See the License for the specific language governing
//permissions and limitations under the License.

//*/

namespace ManyWho.Flow.SDK.Utils
{
    public class HttpUtils
    {
        public const int MAXIMUM_RETRIES = 3;
        public const int TIMEOUT_SECONDS = 20;
        public const int SYSTEM_TIMEOUT_SECONDS = 500;
        public const int TIMEOUT_SECONDS_FOR_USER_INTERACTIONS = 600;
        public const int TIMEOUT_SECONDS_FOR_SYSTEM_INTERACTIONS = 300;

        public const string HEADER_AUTHORIZATION = "Authorization";
        public const string HEADER_MANYWHO_STATE = "ManyWhoState";
        public const string HEADER_MANYWHO_TENANT = "ManyWhoTenant";
        public const string HEADER_CULTURE = "Culture";

        /// <summary>
        /// Utility method for getting the authenticated who from the header.
        /// </summary>
        public static IAuthenticatedWho GetWho(string authorizationHeader)
        {
            IAuthenticatedWho authenticatedWho = null;

            // Check to see if it's null - it can be in some situations
            if (!string.IsNullOrWhiteSpace(authorizationHeader))
            {
                // Deserialize into an object
                authenticatedWho = AuthenticationUtils.Deserialize(Uri.EscapeDataString(authorizationHeader));
            }

            return authenticatedWho;
        }
        
        public static HttpClient CreateHttpClient(IAuthenticatedWho authenticatedWho, string tenantId, string stateId)
        {
            return CreateHttpClient(authenticatedWho, tenantId, stateId, TIMEOUT_SECONDS);
        }

        public static HttpClient CreateHttpClient(IAuthenticatedWho authenticatedWho, string tenantId, string stateId, int timeOut)
        {
            HttpClient httpClient = null;

            httpClient = new HttpClient();

            if (authenticatedWho != null)
            {
                // Serialize and add the user information to the header
                httpClient.DefaultRequestHeaders.Add(HEADER_AUTHORIZATION, Uri.EscapeDataString(AuthenticationUtils.Serialize(authenticatedWho)));
            }

            if (!string.IsNullOrWhiteSpace(tenantId))
            {
                // Add the tenant to the header
                httpClient.DefaultRequestHeaders.Add(HEADER_MANYWHO_TENANT, tenantId);
            }

            if (!string.IsNullOrWhiteSpace(stateId))
            {
                // Add the state to the header
                httpClient.DefaultRequestHeaders.Add(HEADER_MANYWHO_STATE, stateId);
            }

            // Set the timeout for the request
            httpClient.Timeout = TimeSpan.FromSeconds(timeOut);

            return httpClient;
        }

        public static bool IsWorthRetry(HttpStatusCode httpStatusCode)
        {
            bool isWorthRetry = true;

            // If we get any of these status codes, there's no point hammering the service again as the request either got there and an error
            // occurred, or we're referencing something that isn't there (though if we get a "NOT FOUND", we do try again just in case!)
            if (httpStatusCode == HttpStatusCode.Forbidden ||
                httpStatusCode == HttpStatusCode.MethodNotAllowed ||
                httpStatusCode == HttpStatusCode.Moved ||
                httpStatusCode == HttpStatusCode.MovedPermanently ||
                httpStatusCode == HttpStatusCode.NotImplemented ||
                httpStatusCode == HttpStatusCode.PreconditionFailed ||
                httpStatusCode == HttpStatusCode.ProxyAuthenticationRequired ||
                httpStatusCode == HttpStatusCode.Redirect ||
                httpStatusCode == HttpStatusCode.RedirectKeepVerb ||
                httpStatusCode == HttpStatusCode.RedirectMethod ||
                httpStatusCode == HttpStatusCode.RequestEntityTooLarge ||
                httpStatusCode == HttpStatusCode.RequestUriTooLong ||
                httpStatusCode == HttpStatusCode.SeeOther ||
                httpStatusCode == HttpStatusCode.Unauthorized ||
                httpStatusCode == HttpStatusCode.UnsupportedMediaType ||
                httpStatusCode == HttpStatusCode.UseProxy ||
                httpStatusCode == HttpStatusCode.BadRequest ||
                httpStatusCode == HttpStatusCode.InternalServerError)
            {
                isWorthRetry = false;
            }

            return isWorthRetry;
        }
    }
}
