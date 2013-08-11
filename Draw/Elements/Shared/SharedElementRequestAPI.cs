using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Map;
using ManyWho.Flow.SDK.Draw.Elements.Type;

namespace ManyWho.Flow.SDK.Draw.Elements.Shared
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class SharedElementRequestAPI : SharedElementAPI
    {
        [DataMember]
        public Boolean isFixed
        {
            get;
            set;
        }

        [DataMember]
        public String access
        {
            get;
            set;
        }

        [DataMember]
        public String contentType
        {
            get;
            set;
        }

        [DataMember]
        public String defaultContentValue
        {
            get;
            set;
        }

        [DataMember]
        public List<OperationAPI> initializationOperations
        {
            get;
            set;
        }

        [DataMember]
        public String type
        {
            get;
            set;
        }

        [DataMember]
        public Boolean updateByName
        {
            get;
            set;
        }
    }
}