using System;

namespace ManyWho.Flow.SDK.Draw.Flow
{
    public class FlowMinimalAPI
    {
        public FlowIdAPI id
        {
            get;
            set;
        }

        public string developerName
        {
            get;
            set;
        }

        public string developerSummary
        {
            get;
            set;
        }

        public DateTimeOffset dateCreated
        {
            get;
            set;
        }

        public DateTimeOffset dateModified
        {
            get;
            set;
        }
    }
}