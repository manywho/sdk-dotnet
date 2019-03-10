using System;

namespace ManyWho.Flow.SDK.Admin
{
    public class StoreCreateResponse
    {
        public Guid Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Endpoint
        {
            get;
            set;
        }

        public string PlatformKey
        {
            get;
            set;
        }

        public string ReceiverKey
        {
            get;
            set;
        }
    }
}