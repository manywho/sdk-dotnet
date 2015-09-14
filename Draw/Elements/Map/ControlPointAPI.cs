using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Elements.Map
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ControlPointAPI
    {
        public int x
        {
            get;
            set;
        }

        public int y
        {
            get;
            set;
        }
    }
}
