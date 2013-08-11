using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.Elements.Config;

namespace ManyWho.Flow.SDK.Run.Elements.Type
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ObjectDataResponseAPI
    {
        /// <summary>
        /// The culture for the service response.
        /// </summary>
        [DataMember]
        public CultureAPI culture
        {
            get;
            set;
        }

        /// <summary>
        /// The list of objects post select, insert, update, delete
        /// </summary>
        [DataMember]
        public List<ObjectAPI> objectData
        {
            get;
            set;
        }
    }
}