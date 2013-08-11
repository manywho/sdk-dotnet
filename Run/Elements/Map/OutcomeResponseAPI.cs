using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run.Elements.Map
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class OutcomeResponseAPI
    {
        [DataMember]
        public String id
        {
            get;
            set;
        }

        [DataMember]
        public String developerName
        {
            get;
            set;
        }

        [DataMember]
        public String label
        {
            get;
            set;
        }

        [DataMember]
        public String pageActionBinding
        {
            get;
            set;
        }

        [DataMember]
        public String pageElementBindingId
        {
            get;
            set;
        }

        [DataMember]
        public Int32 order
        {
            get;
            set;
        }
    }
}