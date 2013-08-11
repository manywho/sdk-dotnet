using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Run.Elements.Map;
using ManyWho.Flow.SDK.Run.Elements.UI;

namespace ManyWho.Flow.SDK.Run.Elements.Config
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class UIServiceResponseAPI : ServiceResponseAPI
    {
        [DataMember]
        public PageResponseAPI formResponse
        {
            get;
            set;
        }

        [DataMember]
        public List<OutcomeResponseAPI> outcomeResponses
        {
            get;
            set;
        }

        [DataMember]
        public Boolean isComplete
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
    }
}
