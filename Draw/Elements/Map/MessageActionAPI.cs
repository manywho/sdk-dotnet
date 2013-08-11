using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Elements.Map
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class MessageActionAPI
    {
        [DataMember]
        public String id
        {
            get;
            set;
        }

        [DataMember]
        public String developerName
        {
            get;
            set;
        }

        [DataMember]
        public String serviceElementId
        {
            get;
            set;
        }

        [DataMember]
        public String uriPart
        {
            get;
            set;
        }

        [DataMember]
        public List<MessageInputAPI> inputs
        {
            get;
            set;
        }

        [DataMember]
        public List<MessageOutputAPI> outputs
        {
            get;
            set;
        }
    }
}