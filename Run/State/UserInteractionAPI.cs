using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run.State
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class UserInteractionAPI : GeoLocationAPI
    {
        [DataMember]
        public String manywhoUserId
        {
            get;
            set;
        }
    }
}
