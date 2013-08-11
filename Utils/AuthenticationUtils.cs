using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Net;
using System.Threading.Tasks;
using ManyWho.Flow.SDK.Security;

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
            String emailParameter = null;

            // Start by splitting the string so we have a complete key/value pairing
            parameters = token.Split('&');

            // Grab the parameters for each of the properties from the array
            manywhoTenantIdParameter = parameters.Single(value => value.StartsWith(Constants.AUTHENTICATED_WHO_TOKEN_MANYWHO_TENANT_ID, StringComparison.OrdinalIgnoreCase));
            manywhoUserIdParameter = parameters.Single(value => value.StartsWith(Constants.AUTHENTICATED_WHO_TOKEN_MANYWHO_USER_ID, StringComparison.OrdinalIgnoreCase));
            manywhoTokenParameter = parameters.Single(value => value.StartsWith(Constants.AUTHENTICATED_WHO_TOKEN_MANYWHO_TOKEN, StringComparison.OrdinalIgnoreCase));
            directoryIdParameter = parameters.Single(value => value.StartsWith(Constants.AUTHENTICATED_WHO_TOKEN_DIRECTORY_ID, StringComparison.OrdinalIgnoreCase));
            directoryNameParameter = parameters.Single(value => value.StartsWith(Constants.AUTHENTICATED_WHO_TOKEN_DIRECTORY_NAME, StringComparison.OrdinalIgnoreCase));
            emailParameter = parameters.Single(value => value.StartsWith(Constants.AUTHENTICATED_WHO_TOKEN_EMAIL, StringComparison.OrdinalIgnoreCase));
            identityProviderParameter = parameters.Single(value => value.StartsWith(Constants.AUTHENTICATED_WHO_TOKEN_IDENTITY_PROVIDER, StringComparison.OrdinalIgnoreCase));
            tenantNameParameter = parameters.Single(value => value.StartsWith(Constants.AUTHENTICATED_WHO_TOKEN_TENANT_NAME, StringComparison.OrdinalIgnoreCase));
            tokenParameter = parameters.Single(value => value.StartsWith(Constants.AUTHENTICATED_WHO_TOKEN_TOKEN, StringComparison.OrdinalIgnoreCase));
            userIdParameter = parameters.Single(value => value.StartsWith(Constants.AUTHENTICATED_WHO_TOKEN_USER_ID, StringComparison.OrdinalIgnoreCase));

            // Check to make sure we have all of the parameters - they're all required
            if (manywhoTenantIdParameter == null ||
                manywhoTenantIdParameter.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing parameter: " + Constants.AUTHENTICATED_WHO_TOKEN_MANYWHO_TENANT_ID);
            }

            if (manywhoUserIdParameter == null ||
                manywhoUserIdParameter.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing parameter: " + Constants.AUTHENTICATED_WHO_TOKEN_MANYWHO_USER_ID);
            }

            if (manywhoTokenParameter == null ||
                manywhoTokenParameter.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing parameter: " + Constants.AUTHENTICATED_WHO_TOKEN_MANYWHO_TOKEN);
            }

            if (directoryIdParameter == null ||
                directoryIdParameter.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing parameter: " + Constants.AUTHENTICATED_WHO_TOKEN_DIRECTORY_ID);
            }

            if (directoryNameParameter == null ||
                directoryNameParameter.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing parameter: " + Constants.AUTHENTICATED_WHO_TOKEN_DIRECTORY_NAME);
            }

            if (emailParameter == null ||
                emailParameter.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing parameter: " + Constants.AUTHENTICATED_WHO_TOKEN_EMAIL);
            }

            if (identityProviderParameter == null ||
                identityProviderParameter.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing parameter: " + Constants.AUTHENTICATED_WHO_TOKEN_IDENTITY_PROVIDER);
            }

            if (tenantNameParameter == null ||
                tenantNameParameter.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing parameter: " + Constants.AUTHENTICATED_WHO_TOKEN_TENANT_NAME);
            }
            
            if (tokenParameter == null ||
                tokenParameter.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing parameter: " + Constants.AUTHENTICATED_WHO_TOKEN_TOKEN);
            }

            if (userIdParameter == null ||
                userIdParameter.Trim().Length == 0)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.Forbidden, "Missing parameter: " + Constants.AUTHENTICATED_WHO_TOKEN_USER_ID);
            }

            // Create our new authenticated who object
            authenticatedWho = new AuthenticatedWho();
            authenticatedWho.ManyWhoTenantId = Guid.Parse(manywhoTenantIdParameter.Split(Constants.AUTHENTICATED_WHO_DELIMITER)[1]);
            authenticatedWho.ManyWhoUserId = Guid.Parse(manywhoUserIdParameter.Split(Constants.AUTHENTICATED_WHO_DELIMITER)[1]);
            authenticatedWho.ManyWhoToken = manywhoTokenParameter.Split(Constants.AUTHENTICATED_WHO_DELIMITER)[1];
            authenticatedWho.DirectoryId = directoryIdParameter.Split(Constants.AUTHENTICATED_WHO_DELIMITER)[1];
            authenticatedWho.DirectoryName = directoryNameParameter.Split(Constants.AUTHENTICATED_WHO_DELIMITER)[1];
            authenticatedWho.Email = emailParameter.Split(Constants.AUTHENTICATED_WHO_DELIMITER)[1];
            authenticatedWho.IdentityProvider = identityProviderParameter.Split(Constants.AUTHENTICATED_WHO_DELIMITER)[1];
            authenticatedWho.TenantName = tenantNameParameter.Split(Constants.AUTHENTICATED_WHO_DELIMITER)[1];
            authenticatedWho.Token = tokenParameter.Split(Constants.AUTHENTICATED_WHO_DELIMITER)[1];
            authenticatedWho.UserId = userIdParameter.Split(Constants.AUTHENTICATED_WHO_DELIMITER)[1];

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
            token += Constants.AUTHENTICATED_WHO_TOKEN_MANYWHO_TENANT_ID + Constants.AUTHENTICATED_WHO_DELIMITER + authenticatedWho.ManyWhoTenantId.ToString() + "&";
            token += Constants.AUTHENTICATED_WHO_TOKEN_MANYWHO_USER_ID + Constants.AUTHENTICATED_WHO_DELIMITER + authenticatedWho.ManyWhoUserId.ToString() + "&";
            token += Constants.AUTHENTICATED_WHO_TOKEN_MANYWHO_TOKEN + Constants.AUTHENTICATED_WHO_DELIMITER + authenticatedWho.ManyWhoToken + "&";
            token += Constants.AUTHENTICATED_WHO_TOKEN_DIRECTORY_ID + Constants.AUTHENTICATED_WHO_DELIMITER + authenticatedWho.DirectoryId + "&";
            token += Constants.AUTHENTICATED_WHO_TOKEN_DIRECTORY_NAME + Constants.AUTHENTICATED_WHO_DELIMITER + authenticatedWho.DirectoryName + "&";
            token += Constants.AUTHENTICATED_WHO_TOKEN_EMAIL + Constants.AUTHENTICATED_WHO_DELIMITER + authenticatedWho.Email + "&";
            token += Constants.AUTHENTICATED_WHO_TOKEN_IDENTITY_PROVIDER + Constants.AUTHENTICATED_WHO_DELIMITER + authenticatedWho.IdentityProvider + "&";
            token += Constants.AUTHENTICATED_WHO_TOKEN_TENANT_NAME + Constants.AUTHENTICATED_WHO_DELIMITER + authenticatedWho.TenantName + "&";
            token += Constants.AUTHENTICATED_WHO_TOKEN_TOKEN + Constants.AUTHENTICATED_WHO_DELIMITER + authenticatedWho.Token + "&";
            token += Constants.AUTHENTICATED_WHO_TOKEN_USER_ID + Constants.AUTHENTICATED_WHO_DELIMITER + authenticatedWho.UserId;

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
