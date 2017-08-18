using System;
using ManyWho.Flow.SDK.Security;

namespace ManyWho.Flow.SDK.Utils
{
    public class NotificationUtils
    {
        public const String MEDIA_TYPE_PLAIN = "text/plain";
        public const String MEDIA_TYPE_HTML = "text/html";
        
        public static String SerializeAuthenticatedWhoInfo(String mediaType, IAuthenticatedWho authenticatedWho)
        {
            String authenticatedWhoInfo = String.Empty;

            if (mediaType.Equals(MEDIA_TYPE_PLAIN, StringComparison.OrdinalIgnoreCase) == true)
            {
                if (authenticatedWho != null)
                {
                    authenticatedWhoInfo += "Name: " + authenticatedWho.FirstName + " " + authenticatedWho.LastName + Environment.NewLine;
                    authenticatedWhoInfo += "Email: " + authenticatedWho.Email + Environment.NewLine;
                    authenticatedWhoInfo += "User: " + authenticatedWho.Username + " (Id: " + authenticatedWho.UserId + ")" + Environment.NewLine;
                    authenticatedWhoInfo += "Directory: " + authenticatedWho.DirectoryName + " (Id: " + authenticatedWho.DirectoryId + ")" + Environment.NewLine;
                    authenticatedWhoInfo += "Tenant: " + authenticatedWho.TenantName + "(Id: " + authenticatedWho.ManyWhoTenantId + ")" + Environment.NewLine;
                }
                else
                {
                    authenticatedWhoInfo += "Unknown" + Environment.NewLine;
                }
            }
            else
            {
                throw new ArgumentNullException("MediaType", "The media type provided is not supported for serializing AuthenticateWho information.");
            }

            return authenticatedWhoInfo;
        }
    }
}
