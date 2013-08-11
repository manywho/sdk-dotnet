using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManyWho.Flow.SDK.Security
{
    public interface IAuthenticatedWho
    {
        /// <summary>
        /// The unique identifier for the user in ManyWho.
        /// </summary>
        Guid ManyWhoUserId
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the tenant in ManyWho.  If logging in as a runtime user, this will be blank.  This field is only required for users
        /// logging in to build flows as it will be used for all filtering of elements.
        /// </summary>
        Guid ManyWhoTenantId
        {
            get;
            set;
        }

        /// <summary>
        /// The authentication token used by ManyWho.
        /// </summary>
        String ManyWhoToken
        {
            get;
            set;
        }

        /// <summary>
        /// The current geo location of the user making the request.  This object can be null depending on the permissions accepted by the end user.
        /// </summary>
        IGeoLocation GeoLocation
        {
            get;
            set;
        }

        /// <summary>
        /// The user identifier as provided post authentication and authorization with the service.
        /// </summary>
        String UserId
        {
            get;
            set;
        }

        /// <summary>
        /// The identifier provider as provided post authentication and authorization with the service.
        /// </summary>
        String IdentityProvider
        {
            get;
            set;
        }

        /// <summary>
        /// The token as provided post authentication and authorization with the service.
        /// </summary>
        String Token
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the tenant being logged into.
        /// </summary>
        String TenantName
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the remote directory that was used to perform the login.
        /// </summary>
        String DirectoryName
        {
            get;
            set;
        }

        /// <summary>
        /// The unique identifier for the directory.
        /// </summary>
        String DirectoryId
        {
            get;
            set;
        }

        /// <summary>
        /// The validated email address for this user.
        /// </summary>
        String Email
        {
            get;
            set;
        }
    }
}
