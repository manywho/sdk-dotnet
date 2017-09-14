using System;
using System.Collections.Generic;

namespace ManyWho.Flow.SDK.Run
{
    public class EngineSimpleInitializationRequestAPI
    {
        public Guid Id
        {
            get;
            set;
        }

        public Guid VersionId
        {
            get;
            set;
        }

        public string DeveloperName
        {
            get;
            set;
        }

        public List<EngineValueAPI> Inputs
        {
            get;
            set;
        }

        public string Player
        {
            get;
            set;
        }
    }
}
