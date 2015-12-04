using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Recording
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class StatePlaybackResponseAPI
    {
        [DataMember]
        public Guid Id
        {
            get;
            set;
        }

        [DataMember]
        public Guid StateId
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
        public Guid? CurrentMapElementId
        {
            get;
            set;
        }

        [DataMember]
        public string CurrentMapElementDeveloperName
        {
            get;
            set;
        }

        [DataMember]
        public string Status
        {
            get;
            set;
        }

        [DataMember]
        public string AuthenticationToken
        {
            get;
            set;
        }

        [DataMember]
        public Dictionary<string, string> RootFaults
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

        [DataMember]
        public DateTimeOffset ModifiedAt
        {
            get;
            set;
        }
    }
}
