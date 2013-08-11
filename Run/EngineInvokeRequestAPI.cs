using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.State;
using ManyWho.Flow.SDK.Run.Elements.Map;

namespace ManyWho.Flow.SDK.Run
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class EngineInvokeRequestAPI
    {
        [DataMember]
        public String stateId
        {
            get;
            set;
        }

        [DataMember]
        public String stateToken
        {
            get;
            set;
        }

        [DataMember]
        public String currentMapElementId
        {
            get;
            set;
        }

        [DataMember]
        public String invokeType
        {
            get;
            set;
        }

        [DataMember]
        public Dictionary<String, String> annotations
        {
            get;
            set;
        }

        [DataMember]
        public GeoLocationAPI geoLocation
        {
            get;
            set;
        }

        [DataMember]
        public MapElementInvokeRequestAPI mapElementInvokeRequest
        {
            get;
            set;
        }

        [DataMember]
        public String mode
        {
            get;
            set;
        }
    }
}
