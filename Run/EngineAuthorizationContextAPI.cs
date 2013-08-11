using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class EngineAuthorizationContextAPI
    {
        [DataMember]
        public String directoryName
        {
            get;
            set;
        }

        [DataMember]
        public String directoryId
        {
            get;
            set;
        }

        [DataMember]
        public String loginUrl
        {
            get;
            set;
        }
    }
}
