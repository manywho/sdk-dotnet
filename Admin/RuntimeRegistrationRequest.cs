namespace ManyWho.Flow.SDK.Admin
{
    public class RuntimeRegistrationRequest
    {
        /// <summary>
        /// The one-time installation token, generated when the runtime was first created
        /// </summary>
        public string InstallationToken
        {
            get;
            set;
        }
    }
}