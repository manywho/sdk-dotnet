using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run.State
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class UserVoteAPI : GeoLocationAPI
    {
        [DataMember]
        public string selectedOutcomeId
        {
            get;
            set;
        }

        [DataMember]
        public string directoryUserId
        {
            get;
            set;
        }

        [DataMember]
        public string manywhoUserId
        {
            get;
            set;
        }
    }
}
