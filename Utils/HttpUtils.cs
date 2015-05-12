using System;
using System.Collections.Generic;
using System.Linq;
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
        public const Int32 MAXIMUM_RETRIES = 3;
        public const Int32 TIMEOUT_SECONDS = 20;
        public const Int32 SYSTEM_TIMEOUT_SECONDS = 500;

        public const String HEADER_AUTHORIZATION = "Authorization";
        public const String HEADER_MANYWHO_STATE = "ManyWhoState";
        public const String HEADER_MANYWHO_TENANT = "ManyWhoTenant";
        public const String HEADER_CULTURE = "Culture";

        /// <summary>
        /// Utility method for getting the authenticated who from the header.
        /// </summary>
        public static IAuthenticatedWho GetWho(String authorizationHeader)
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
    }
}
