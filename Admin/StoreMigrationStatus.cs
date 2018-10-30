using System;

namespace ManyWho.Flow.SDK.Admin
{
    public class StoreMigrationStatus
    {
        public Guid Id
        {
            get;
            set;
        }

        public Guid StoreId
        {
            get;
            set;
        }

        public Guid UserId
        {
            get;
            set;
        }

        public string Status
        {
            get;
            set;
        }
        
        public string ErrorCause
        {
            get;
            set;
        }
        
        public DateTimeOffset StartedAt
        {
            get;
            set;
        }
        
        public DateTimeOffset UpdatedAt
        {
            get;
            set;
        }
        
        public DateTimeOffset? EndedAt
        {
            get;
            set;
        }
    }
}