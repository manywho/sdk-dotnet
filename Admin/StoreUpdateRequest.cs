namespace ManyWho.Flow.SDK.Admin
{
    public class StoreUpdateRequest
    {
        /// <summary>
        /// The (optional) new name of the store
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// The (optional) new endpoint of the store, which must support HTTPS.
        /// </summary>
        public string Endpoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// The (optional) new endpoint's username for Basic HTTP Authentication
        /// </summary>
        public string EndpointBasicUsername
        {
            get;
            set;
        }
        
        /// <summary>
        /// The (optional) new endpoint's password for Basic HTTP Authentication
        /// </summary>
        public string EndpointBasicPassword
        {
            get;
            set;
        }
    }
}