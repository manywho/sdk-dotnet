using System;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Elements.Value
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ValueElementInSubflowIdAPI
    {
        public ValueElementInSubflowIdAPI()
        {

        }

        public ValueElementInSubflowIdAPI(Guid id)
        {
            this.id = id;
        }
        
        /// <summary>
        /// The unique identifier for the Value to be referenced with this identifier.
        /// </summary>
        [DataMember]
        public Guid id
        {
            get;
            set;
        }
    }
}
