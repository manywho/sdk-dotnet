using System.Collections.Generic;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Elements.Config;
using ManyWho.Flow.SDK.Draw.Elements.Group;
using ManyWho.Flow.SDK.Draw.Elements.Map;
using ManyWho.Flow.SDK.Draw.Elements.Type;
using ManyWho.Flow.SDK.Draw.Elements.UI;
using ManyWho.Flow.SDK.Draw.Elements.Value;

namespace ManyWho.Flow.SDK.Draw.Flow
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class FlowImageResponseAPI : FlowResponseAPI
    {
        [DataMember]
        public List<NavigationElementResponseAPI> navigationElements
        {
            get;
            set;
        }

        [DataMember]
        public List<MapElementResponseAPI> mapElements
        {
            get;
            set;
        }

        [DataMember]
        public List<GroupElementResponseAPI> groupElements
        {
            get;
            set;
        }

        [DataMember]
        public List<PageElementResponseAPI> pageElements
        {
            get;
            set;
        }

        [DataMember]
        public List<ValueElementResponseAPI> valueElements
        {
            get;
            set;
        }

        [DataMember]
        public List<MacroElementResponseAPI> macroElements
        {
            get;
            set;
        }

        [DataMember]
        public List<ServiceElementResponseAPI> serviceElements
        {
            get;
            set;
        }

        [DataMember]
        public List<TypeElementResponseAPI> typeElements
        {
            get;
            set;
        }

        [DataMember]
        public List<TagElementResponseAPI> tagElements
        {
            get;
            set;
        }
    }
}
