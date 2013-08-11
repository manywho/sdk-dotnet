using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.Elements.Type;

namespace ManyWho.Flow.SDK.Run
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class EngineValueResponseAPI : EngineValueRequestAPI
    {
        [DataMember]
        public String TypeElementId
        {
            get;
            set;
        }

        [DataMember]
        public String TypeElementDeveloperName
        {
            get;
            set;
        }
    }
}
