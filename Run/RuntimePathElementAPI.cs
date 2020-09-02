using System;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class RuntimePathElementAPI
    {
        /// <summary>
        /// The ID of the Flow
        /// </summary>
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
    }
}