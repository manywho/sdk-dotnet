using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.State;
using ManyWho.Flow.SDK.Run.Elements.UI;

namespace ManyWho.Flow.SDK.Run.Elements.Map
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class MapElementInvokeRequestAPI
    {
        [DataMember]
        public String selectedOutcomeId
        {
            get;
            set;
        }

        [DataMember]
        public PageRequestAPI pageRequest
        {
            get;
            set;
        }
    }
}
