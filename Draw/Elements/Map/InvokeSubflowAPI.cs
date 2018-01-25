using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Flow;

namespace ManyWho.Flow.SDK.Draw.Elements.Map
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class InvokeSubflowAPI
    {
        /// <summary>
        /// The composite unique identifier for the Flow you wish to run. The engine will only respect the "id" part of the unique identifier and will always opt to run the latest active/default version of the Flow.
        /// </summary>
        [DataMember]
        public FlowIdAPI flowId
        {
            get;
            set;
        }
    }
}