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
        /// <summary>
        /// The complete object metadata for all Navigations in your Flow.
        /// </summary>
        [DataMember]
        public List<NavigationElementResponseAPI> navigationElements
        {
            get;
            set;
        }

        /// <summary>
        /// The complete object metadata for all Map Elements in your Flow.
        /// </summary>
        [DataMember]
        public List<MapElementResponseAPI> mapElements
        {
            get;
            set;
        }

        /// <summary>
        /// The complete object metadata for all Groups in your Flow.
        /// </summary>
        [DataMember]
        public List<GroupElementResponseAPI> groupElements
        {
            get;
            set;
        }

        /// <summary>
        /// The complete object metadata for all Pages in your Flow.
        /// </summary>
        [DataMember]
        public List<PageElementResponseAPI> pageElements
        {
            get;
            set;
        }

        /// <summary>
        /// The complete object metadata for all Values in your Flow.
        /// </summary>
        [DataMember]
        public List<ValueElementResponseAPI> valueElements
        {
            get;
            set;
        }

        /// <summary>
        /// The complete object metadata for all Macros in your Flow.
        /// </summary>
        [DataMember]
        public List<MacroElementResponseAPI> macroElements
        {
            get;
            set;
        }

        /// <summary>
        /// The complete object metadata for all Services in your Flow.
        /// </summary>
        [DataMember]
        public List<ServiceElementResponseAPI> serviceElements
        {
            get;
            set;
        }

        /// <summary>
        /// The complete object metadata for all Types in your Flow.
        /// </summary>
        [DataMember]
        public List<TypeElementResponseAPI> typeElements
        {
            get;
            set;
        }

        /// <summary>
        /// The complete object metadata for all Tags in your Flow.
        /// </summary>
        [DataMember]
        public List<TagElementResponseAPI> tagElements
        {
            get;
            set;
        }
    }
}
