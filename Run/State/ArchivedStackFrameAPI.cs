using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run.State
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ArchivedStackFrameAPI
    {
        /// <summary>
        /// The runtime path of the Subflow map element that is associated with this Archived Stack Frame
        /// </summary>
        [DataMember]
        public List<RuntimePathElementAPI> path { get; set; }
        
        /// <summary>
        /// Archived values of value elements
        /// </summary>
        [DataMember]
        public List<StateValueAPI> values { get; set; }
    }
}