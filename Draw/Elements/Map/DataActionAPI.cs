using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Type;
using ManyWho.Flow.SDK.Draw.Elements.Shared;

namespace ManyWho.Flow.SDK.Draw.Elements.Map
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class DataActionAPI
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
        public String crudOperation
        {
            get;
            set;
        }

        [DataMember]
        public SharedElementIdAPI sharedElementContentValueToReference
        {
            get;
            set;
        }

        [DataMember]
        public SharedElementIdAPI sharedElementToApplyContentValue
        {
            get;
            set;
        }

        [DataMember]
        public ObjectDataRequestConfigAPI objectDataRequestProperties
        {
            get;
            set;
        }
    }
}
