using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Elements.Map
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ControlPointAPI
    {
        [DataMember]
        public int x
        {
            get;
            set;
        }

        [DataMember]
        public int y
        {
            get;
            set;
        }
    }
}
