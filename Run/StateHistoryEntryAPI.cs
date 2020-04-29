using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class StateHistoryEntryAPI
    {
        [DataMember]
        public Guid flowId
        {
            get;
            set;
        }

        /// <summary>
        /// The ID of the Map Element
        /// </summary>
        [DataMember]
        public Guid mapElementId
        {
            get;
            set;
        }
        
        /// <summary>
        /// The runtime path of the Map Element
        /// </summary>
        [DataMember]
        public List<RuntimePathElementAPI> path
        {
            get;
            set;
        }
    }
}