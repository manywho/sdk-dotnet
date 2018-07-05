namespace ManyWho.Flow.SDK.Admin
{
    public class StoreCreateRequest
    {
        /// <summary>
        /// A descriptive name of the store
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// The endpoint the store is hosted at, which must support HTTPS.
        /// </summary>
        public string Endpoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// (Optional) The endpoint's username for Basic HTTP Authentication
        /// </summary>
        public string EndpointBasicUsername
        {
            get;
            set;
        }
        
        /// <summary>
        /// (Optional) The endpoint's password for Basic HTTP Authentication
        /// </summary>
        public string EndpointBasicPassword
        {
            get;
            set;
        }
    }
}