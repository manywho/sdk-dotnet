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

        public StoreAuthentication Authentication
        {
            get;
            set;
        }
    }
}