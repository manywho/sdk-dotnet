using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManyWho.Flow.SDK.Draw.Elements.Map
{
    public class MapElementCoordinatesAPI
    {
        public MapElementIdAPI MapElementId
        {
            get;
            set;
        }

        public String Name
        {
            get;
            set;
        }

        public String Summary
        {
            get;
            set;
        }

        public Int32 X
        {
            get;
            set;
        }

        public Int32 Y
        {
            get;
            set;
        }
    }
}