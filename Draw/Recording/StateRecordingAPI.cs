using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Recording
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class StateRecordingAPI
    {
        [DataMember]
        public Guid StateId
        {
            get;
            set;
        }

        [DataMember]
        public string Description
        {
            get;
            set;
        }

        [DataMember]
        public Guid TenantId
        {
            get;
            set;
        }

        [DataMember]
        public Guid FlowId
        {
            get;
            set;
        }

        [DataMember]
        public Guid FlowVersionId
        {
            get;
            set;
        }

        [DataMember]
        public bool IsPublic
        {
            get;
            set;
        }

        [DataMember]
        public List<StatePlaybackResponseAPI> Playbacks
        {
            get;
            set;
        }

        [DataMember]
        public DateTimeOffset CreatedAt
        {
            get;
            set;
        }
    }
}
