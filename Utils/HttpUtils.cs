using System;
using System.Net.Http;
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
        public const int MAXIMUM_RETRIES = 3;
        public const int TIMEOUT_SECONDS = 20;

        public const string HEADER_AUTHORIZATION = "Authorization";
        public const string HEADER_MANYWHO_STATE = "ManyWhoState";
        public const string HEADER_MANYWHO_TENANT = "ManyWhoTenant";
        public const string HEADER_CULTURE = "Culture";

        public static HttpClient CreateHttpClient(IAuthenticatedWho authenticatedWho, string tenantId, string stateId)
        {
            return CreateHttpClient(authenticatedWho, tenantId, stateId, TIMEOUT_SECONDS);
        }

        public static HttpClient CreateHttpClient(IAuthenticatedWho authenticatedWho, string tenantId, string stateId, int timeOut)
        {
            return CreateHttpClient(Uri.EscapeDataString(AuthenticationUtils.Serialize(authenticatedWho)), tenantId, stateId, timeOut);
        }

        public static HttpClient CreateHttpClient(string authorizationHeader, string tenantId, string stateId, int timeOut)
        {
            HttpClient httpClient = null;

            httpClient = new HttpClient();

            if (authorizationHeader != null)
            {
                // Serialize and add the user information to the header
                httpClient.DefaultRequestHeaders.Add(HEADER_AUTHORIZATION, authorizationHeader);
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

        public static HttpClient CreateRuntimeHttpClient(string authenticationToken, string tenantId, string stateId)
        {
            return CreateRuntimeHttpClient(authenticationToken, tenantId, stateId, TIMEOUT_SECONDS);
        }

        public static HttpClient CreateRuntimeHttpClient(string authenticationToken, string tenantId, string stateId, int timeOut)
        {
            HttpClient httpClient = null;

            httpClient = new HttpClient();

            if (string.IsNullOrWhiteSpace(authenticationToken) == false)
            {
                // Serialize and add the user information to the header
                httpClient.DefaultRequestHeaders.Add(HEADER_AUTHORIZATION, Uri.EscapeDataString(authenticationToken));
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
    }
}
