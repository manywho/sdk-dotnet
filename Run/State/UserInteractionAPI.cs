using System;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run.State
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class UserInteractionAPI : GeoLocationAPI
    {
        [DataMember]
        public string manywhoUserId
        {
            get;
            set;
        }
    }
}
