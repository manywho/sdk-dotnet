using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
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
    public class AuthenticationUtils
    {
        public static IAuthenticatedWho Deserialize(String token)
        {
            IAuthenticatedWho authenticatedWho = null;
            String[] parameters = null;
            String directoryIdParameter = null;
            String directoryNameParameter = null;
            String identityProviderParameter = null;
            String manywhoTenantIdParameter = null;
            String manywhoUserIdParameter = null;
            String manywhoTokenParameter = null;
            String tenantNameParameter = null;
            String tokenParameter = null;
            String userIdParameter = null;
            String usernameParameter = null;
            String emailParameter = null;
            String firstNameParameter = null;
            String lastNameParameter = null;

            // Start by splitting the string so we have a complete key/value pairing
            parameters = token.Split('&');

            // Grab the parameters for each of the properties from the array
            manywhoTenantIdParameter = parameters.Single(value => value.StartsWith(ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_MANYWHO_TENANT_ID, StringComparison.OrdinalIgnoreCase));
            manywhoUserIdParameter = parameters.Single(value => value.StartsWith(ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_MANYWHO_USER_ID, StringComparison.OrdinalIgnoreCase));
            manywhoTokenParameter = parameters.Single(value => value.StartsWith(ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_MANYWHO_TOKEN, StringComparison.OrdinalIgnoreCase));
            directoryIdParameter = parameters.Single(value => value.StartsWith(ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_DIRECTORY_ID, StringComparison.OrdinalIgnoreCase));
            directoryNameParameter = parameters.Single(value => value.StartsWith(ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_DIRECTORY_NAME, StringComparison.OrdinalIgnoreCase));
            emailParameter = parameters.Single(value => value.StartsWith(ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_EMAIL, StringComparison.OrdinalIgnoreCase));
            identityProviderParameter = parameters.Single(value => value.StartsWith(ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_IDENTITY_PROVIDER, StringComparison.OrdinalIgnoreCase));
            tenantNameParameter = parameters.Single(value => value.StartsWith(ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_TENANT_NAME, StringComparison.OrdinalIgnoreCase));
            tokenParameter = parameters.Single(value => value.StartsWith(ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_TOKEN, StringComparison.OrdinalIgnoreCase));
            userIdParameter = parameters.Single(value => value.StartsWith(ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_USER_ID, StringComparison.OrdinalIgnoreCase));
            usernameParameter = parameters.Single(value => value.StartsWith(ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_USERNAME, StringComparison.OrdinalIgnoreCase));
            firstNameParameter = parameters.Single(value => value.StartsWith(ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_FIRST_NAME, StringComparison.OrdinalIgnoreCase));
            lastNameParameter = parameters.Single(value => value.StartsWith(ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_LAST_NAME, StringComparison.OrdinalIgnoreCase));

            // Check to make sure we have all of the parameters
            if (manywhoTenantIdParameter == null ||
                manywhoTenantIdParameter.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing parameter: " + ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_MANYWHO_TENANT_ID);
            }

            if (manywhoUserIdParameter == null ||
                manywhoUserIdParameter.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing parameter: " + ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_MANYWHO_USER_ID);
            }

            if (manywhoTokenParameter == null ||
                manywhoTokenParameter.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing parameter: " + ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_MANYWHO_TOKEN);
            }

            if (directoryIdParameter == null ||
                directoryIdParameter.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing parameter: " + ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_DIRECTORY_ID);
            }

            if (directoryNameParameter == null ||
                directoryNameParameter.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing parameter: " + ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_DIRECTORY_NAME);
            }

            if (emailParameter == null ||
                emailParameter.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing parameter: " + ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_EMAIL);
            }

            if (identityProviderParameter == null ||
                identityProviderParameter.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing parameter: " + ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_IDENTITY_PROVIDER);
            }

            if (tenantNameParameter == null ||
                tenantNameParameter.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing parameter: " + ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_TENANT_NAME);
            }
            
            if (tokenParameter == null ||
                tokenParameter.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing parameter: " + ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_TOKEN);
            }

            if (userIdParameter == null ||
                userIdParameter.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing parameter: " + ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_USER_ID);
            }

            // Create our new authenticated who object
            authenticatedWho = new AuthenticatedWho();
            authenticatedWho.ManyWhoTenantId = Guid.Parse(manywhoTenantIdParameter.Split(ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER)[1]);
            authenticatedWho.ManyWhoUserId = Guid.Parse(manywhoUserIdParameter.Split(ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER)[1]);
            authenticatedWho.ManyWhoToken = manywhoTokenParameter.Split(ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER)[1];
            authenticatedWho.DirectoryId = directoryIdParameter.Split(ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER)[1];
            authenticatedWho.DirectoryName = directoryNameParameter.Split(ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER)[1];
            authenticatedWho.Email = emailParameter.Split(ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER)[1];
            authenticatedWho.IdentityProvider = identityProviderParameter.Split(ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER)[1];
            authenticatedWho.TenantName = tenantNameParameter.Split(ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER)[1];
            authenticatedWho.Token = tokenParameter.Split(ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER)[1];
            authenticatedWho.UserId = userIdParameter.Split(ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER)[1];

            if (firstNameParameter != null &&
                firstNameParameter.Trim().Length > 0)
            {
                authenticatedWho.FirstName = firstNameParameter.Split(ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER)[1];
            }

            if (lastNameParameter != null &&
                lastNameParameter.Trim().Length > 0)
            {
                authenticatedWho.LastName = lastNameParameter.Split(ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER)[1];
            }

            if (usernameParameter != null &&
                usernameParameter.Trim().Length > 0)
            {
                authenticatedWho.Username = usernameParameter.Split(ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER)[1];
            }

            // Finally, validate the object is OK
            ValidateAuthenticatedWho(authenticatedWho);

            return authenticatedWho;
        }

        public static String Serialize(IAuthenticatedWho authenticatedWho)
        {
            String token = "";

            // Validate the object to make sure we have everything that's needed
            ValidateAuthenticatedWho(authenticatedWho);

            // Construct the token string
            token += ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_MANYWHO_TENANT_ID + ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER + authenticatedWho.ManyWhoTenantId.ToString() + "&";
            token += ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_MANYWHO_USER_ID + ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER + authenticatedWho.ManyWhoUserId.ToString() + "&";
            token += ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_MANYWHO_TOKEN + ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER + authenticatedWho.ManyWhoToken + "&";
            token += ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_DIRECTORY_ID + ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER + authenticatedWho.DirectoryId + "&";
            token += ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_DIRECTORY_NAME + ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER + authenticatedWho.DirectoryName + "&";
            token += ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_EMAIL + ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER + authenticatedWho.Email + "&";
            token += ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_IDENTITY_PROVIDER + ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER + authenticatedWho.IdentityProvider + "&";
            token += ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_TENANT_NAME + ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER + authenticatedWho.TenantName + "&";
            token += ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_TOKEN + ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER + authenticatedWho.Token + "&";
            token += ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_USERNAME + ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER + authenticatedWho.Username + "&";
            token += ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_USER_ID + ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER + authenticatedWho.UserId + "&";
            token += ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_FIRST_NAME + ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER + authenticatedWho.FirstName + "&";
            token += ManyWhoConstants.AUTHENTICATED_WHO_TOKEN_LAST_NAME + ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER + authenticatedWho.LastName;

            // Encode the token ready for http
            return token;
        }

        public static void ValidateAuthenticatedWho(IAuthenticatedWho authenticatedWho)
        {
            if (authenticatedWho.ManyWhoTenantId == null ||
                authenticatedWho.ManyWhoTenantId == Guid.Empty)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing property: ManyWhoTenantId");
            }

            if (authenticatedWho.ManyWhoUserId == null ||
                authenticatedWho.ManyWhoUserId == Guid.Empty)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing property: ManyWhoUserId");
            }

            if (authenticatedWho.ManyWhoToken == null ||
                authenticatedWho.ManyWhoToken.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing property: ManyWhoToken");
            }

            if (authenticatedWho.DirectoryId == null ||
                authenticatedWho.DirectoryId.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing property: DirectoryId");
            }

            if (authenticatedWho.DirectoryName == null ||
                authenticatedWho.DirectoryName.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing property: DirectoryName");
            }

            if (authenticatedWho.Email == null ||
                authenticatedWho.Email.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing property: Email");
            }

            if (authenticatedWho.IdentityProvider == null ||
                authenticatedWho.IdentityProvider.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing property: IdentityProvider");
            }

            if (authenticatedWho.TenantName == null ||
                authenticatedWho.TenantName.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing property: TenantName");
            }

            if (authenticatedWho.Token == null ||
                authenticatedWho.Token.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing property: Token");
            }

            if (authenticatedWho.UserId == null ||
                authenticatedWho.UserId.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing property: UserId");
            }
        }
    }
}
