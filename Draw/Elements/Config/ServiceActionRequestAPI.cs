using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Elements.Config
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ServiceActionRequestAPI
    {
        [DataMember]
        public String id
        {
            get;
            set;
        }

        [DataMember]
        public String uriPart
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
        public String developerSummary
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isViewMessageAction
        {
            get;
            set;
        }

        [DataMember]
        public List<ServiceActionOutcomeAPI> serviceActionOutcomes
        {
            get;
            set;
        }

        [DataMember]
        public List<ServiceValueRequestAPI> serviceInputs
        {
            get;
            set;
        }

        [DataMember]
        public List<ServiceValueRequestAPI> serviceOutputs
        {
            get;
            set;
        }
    }
}