namespace ManyWho.Flow.SDK.Security
{
    public class SamlSettings
    {
        /// <summary>
        /// The public certificate used for validating the signature of any SAML objects.
        /// </summary>
        public string Certificate
        {
            get;
            set;
        }

        /// <summary>
        /// The URI to redirect users to, in order for them to authenticate in the IdP.
        /// </summary>
        public string RedirectUri
        {
            get;
            set;
        }
        
        /// <summary>
        /// The URI to redirect users to, in order for them to logout of the IdP.
        /// </summary>
        public string LogoutUri
        {
            get;
            set;
        }
    }
}