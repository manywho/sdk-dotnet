using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManyWho.Flow.SDK.Run;
using ManyWho.Flow.SDK.Run.State;
using ManyWho.Flow.SDK.Run.Elements.Map;
using ManyWho.Flow.SDK.Draw.Elements.Map;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class EngineInvokeResponseAPI
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
        public String alertEmail
        {
            get;
            set;
        }

        [DataMember]
        public String waitMessage
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
        public List<MapElementInvokeResponseAPI> mapElementInvokeResponses
        {
            get;
            set;
        }

        [DataMember]
        public StateLogAPI stateLog
        {
            get;
            set;
        }

        [DataMember]
        public List<EngineValueAPI> preCommitStateValues
        {
            get;
            set;
        }

        [DataMember]
        public List<EngineValueAPI> stateValues
        {
            get;
            set;
        }

        [DataMember]
        public List<EngineValueAPI> outputs
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
        public String runFlowUri
        {
            get;
            set;
        }

        [DataMember]
        public String joinFlowUri
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
