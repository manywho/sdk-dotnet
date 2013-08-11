using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Describe
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class DescribeValueAPI
    {
        /// <summary>
        /// The developer name for the value.
        /// </summary>
        [DataMember]
        public String developerName
        {
            get;
            set;
        }

        /// <summary>
        /// The content for this value.
        /// </summary>
        [DataMember]
        public String contentValue
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates if the value is required.
        /// </summary>
        [DataMember]
        public Boolean required
        {
            get;
            set;
        }

        /// <summary>
        /// The content type for the value.
        /// </summary>
        [DataMember]
        public String contentType
        {
            get;
            set;
        }

        /// <summary>
        /// This allows the describe value to reference supported types.
        /// </summary>
        [DataMember]
        public String typeExternalId
        {
            get;
            set;
        }
    }
}