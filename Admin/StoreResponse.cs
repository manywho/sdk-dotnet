using System;

namespace ManyWho.Flow.SDK.Admin
{
    public class StoreResponse
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

        public DateTimeOffset CreatedAt
        {
            get;
            set;
        }

        public DateTimeOffset UpdatedAt
        {
            get;
            set;
        }
    }
}