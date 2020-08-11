using System;
using System.Collections.Generic;

namespace ManyWho.Flow.SDK.Draw.Flow
{
    public class FlowSnapshotDeployRequest
    {
        /**
         * A list of one or more runtimes that the snapshot should be deployed to
         */
        public List<Runtime> Runtimes
        {
            get;
            set;
        } = new List<Runtime>();
        
        public class Runtime
        {
            /**
             * The ID of a runtime the snapshot should be deployed to
             */
            public Guid Id
            {
                get;
                set;
            }
        }
    }
}