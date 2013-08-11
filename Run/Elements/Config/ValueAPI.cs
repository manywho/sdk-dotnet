using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.Elements.Type;

namespace ManyWho.Flow.SDK.Run.Elements.Config
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ValueAPI
    {
        /// <summary>
        /// The reference id for this value - which should be used for logging value faults.
        /// </summary>
        [DataMember]
        public String ReferenceId
        {
            get;
            set;
        }

        /// <summary>
        /// The reference type element entry id for this value - which should be used for logging value faults.
        /// </summary>
        [DataMember]
        public String ReferenceTypeElementEntryId
        {
            get;
            set;
        }

        /// <summary>
        /// The developer name for the value.
        /// </summary>
        [DataMember]
        public String DeveloperName
        {
            get;
            set;
        }

        /// <summary>
        /// The Xml for the value.
        /// </summary>
        [DataMember]
        public String ContentValue
        {
            get;
            set;
        }

        /// <summary>
        /// For complex types and list types, we use the object data property so we don't need to serialize and deserialize strings for complex objects.
        /// </summary>
        [DataMember]
        public List<ObjectAPI> ObjectData
        {
            get;
            set;
        }
    }
}