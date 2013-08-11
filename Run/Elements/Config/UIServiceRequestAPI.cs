using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.Elements.UI;

namespace ManyWho.Flow.SDK.Run.Elements.Config
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class UIServiceRequestAPI : ServiceRequestAPI
    {
        [DataMember]
        public String currentMapElementId
        {
            get;
            set;
        }

        [DataMember]
        public String selectedOutcomeId
        {
            get;
            set;
        }

        [DataMember]
        public PageRequestAPI formRequest
        {
            get;
            set;
        }
    }
}
