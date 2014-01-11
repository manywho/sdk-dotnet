using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Config;
using ManyWho.Flow.SDK.Draw.Elements.Group;
using ManyWho.Flow.SDK.Draw.Elements.Map;
using ManyWho.Flow.SDK.Draw.Elements.Type;
using ManyWho.Flow.SDK.Draw.Elements.UI;
using ManyWho.Flow.SDK.Draw.Elements.Value;
using ManyWho.Flow.SDK.Translate.Elements.UI;
using ManyWho.Flow.SDK.Translate.Elements.Map;
using ManyWho.Flow.SDK.Translate.Elements.Value;

namespace ManyWho.Flow.SDK.Translate.Flow
{
    [Serializable]
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class FlowImageTranslationResponseAPI
    {
        [DataMember]
        public String editingToken
        {
            get;
            set;
        }

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
        public String developerSummary
        {
            get;
            set;
        }

        [DataMember]
        public String startMapElementId
        {
            get;
            set;
        }

        [DataMember]
        public List<NavigationElementTranslationResponseAPI> navigationElements
        {
            get;
            set;
        }

        [DataMember]
        public List<MapElementTranslationResponseAPI> mapElements
        {
            get;
            set;
        }

        [DataMember]
        public List<PageElementTranslationResponseAPI> pageElements
        {
            get;
            set;
        }

        [DataMember]
        public List<ValueElementTranslationResponseAPI> valueElements
        {
            get;
            set;
        }
    }
}
