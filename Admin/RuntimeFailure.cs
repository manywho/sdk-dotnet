using System;

namespace ManyWho.Flow.SDK.Admin
{
    public class RuntimeFailure
    {
        /// <summary>
        /// The ID of the failure
        /// </summary>
        public Guid Id
        {
            get;
            set;
        }

        /// <summary>
        /// The actual failure content; usually an exception message
        /// </summary>
        public string Failure
        {
            get;
            set;
        }
        
        public string MessageType
        {
            get;
            set;
        }

        /// <summary>
        /// When the failure happened
        /// </summary>
        public DateTimeOffset OccurredAt
        {
            get;
            set;
        }
    }
}