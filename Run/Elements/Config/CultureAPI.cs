using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run.Elements.Config
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class CultureAPI
    {
        /// <summary>
        /// The language for the culture.
        /// </summary>
        [DataMember]
        public String language
        {
            get;
            set;
        }

        /// <summary>
        /// The country for the culture.
        /// </summary>
        [DataMember]
        public String country
        {
            get;
            set;
        }

        /// <summary>
        /// The variant for the culture.
        /// </summary>
        [DataMember]
        public String variant
        {
            get;
            set;
        }
    }
}