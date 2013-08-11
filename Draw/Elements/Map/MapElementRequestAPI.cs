using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.UI;
using ManyWho.Flow.SDK.Draw.Elements.Config;

namespace ManyWho.Flow.SDK.Draw.Elements.Map
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class MapElementRequestAPI : MapElementAPI
    {
        [DataMember]
        public String pageElementId
        {
            get;
            set;
        }

        [DataMember]
        public List<OperationAPI> operations
        {
            get;
            set;
        }

        [DataMember]
        public MessageActionAPI viewMessageAction
        {
            get;
            set;
        }

        [DataMember]
        public List<MessageActionAPI> messageActions
        {
            get;
            set;
        }

        [DataMember]
        public List<DataActionAPI> dataActions
        {
            get;
            set;
        }

        [DataMember]
        public Boolean postUpdateToStream
        {
            get;
            set;
        }

        [DataMember]
        public String userContent
        {
            get;
            set;
        }

        [DataMember]
        public Boolean updateByName
        {
            get;
            set;
        }
    }
}