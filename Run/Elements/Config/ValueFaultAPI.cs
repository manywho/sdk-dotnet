using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run.Elements.Config
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ValueFaultAPI
    {
        /// <summary>
        /// The reference id of the value with the fault.
        /// </summary>
        [DataMember]
        public String referenceId
        {
            get;
            set;
        }

        /// <summary>
        /// The reference type element entry id of the value with the fault.
        /// </summary>
        [DataMember]
        public String referenceTypeElementEntryId
        {
            get;
            set;
        }

        /// <summary>
        /// The fault code to send back to the engine.
        /// </summary>
        [DataMember]
        public String faultCode
        {
            get;
            set;
        }

        /// <summary>
        /// The fault message to send back to the engine.
        /// </summary>
        [DataMember]
        public String faultMessage
        {
            get;
            set;
        }
    }
}
