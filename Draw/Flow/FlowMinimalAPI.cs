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

        public DateTime dateCreated
        {
            get;
            set;
        }

        public DateTime dateModified
        {
            get;
            set;
        }
    }
}