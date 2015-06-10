using System;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run.State
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class UserVoteAPI : GeoLocationAPI
    {
        [DataMember]
        public String selectedOutcomeId
        {
            get;
            set;
        }

        [DataMember]
        public String directoryUserId
        {
            get;
            set;
        }

        [DataMember]
        public String manywhoUserId
        {
            get;
            set;
        }
    }
}
