using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using ManyWho.Flow.SDK.Utils;
using ManyWho.Flow.SDK.Security;

namespace ManyWho.Flow.SDK.Controller
{
    public class GenericController : ApiController
    {
        /// <summary>
        /// Utility method for getting the authenticated who from the header.
        /// </summary>
        public IAuthenticatedWho GetWho()
        {
            IAuthenticatedWho authenticatedWho = null;
            String authorizationHeader = null;

            // Grab the authorization header string
            authorizationHeader = System.Web.HttpContext.Current.Request.Headers[HttpUtils.HEADER_AUTHORIZATION];

            // Check to see if it's null - it can be in some situations
            if (authorizationHeader != null &&
                authorizationHeader.Trim().Length > 0)
            {
                // Deserialize into an object
                authenticatedWho = AuthenticationUtils.Deserialize(HttpUtility.UrlDecode(authorizationHeader));
            }

            return authenticatedWho;
        }
    }
}