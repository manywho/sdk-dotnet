using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManyWho.Flow.SDK.Run.State;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class EngineInitializationResponseAPI
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
        public String currentStreamId
        {
            get;
            set;
        }

        [DataMember]
        public String statusCode
        {
            get;
            set;
        }

        [DataMember]
        public EngineAuthorizationContextAPI authorizationContext
        {
            get;
            set;
        }
    }
}
