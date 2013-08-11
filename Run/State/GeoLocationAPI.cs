using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run.State
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class GeoLocationAPI
    {
        [DataMember]
        public Decimal latitude
        {
            get;
            set;
        }

        [DataMember]
        public Decimal longitude
        {
            get;
            set;
        }

        [DataMember]
        public Decimal accuracy
        {
            get;
            set;
        }

        [DataMember]
        public Decimal altitude
        {
            get;
            set;
        }

        [DataMember]
        public Decimal altitudeAccuracy
        {
            get;
            set;
        }

        [DataMember]
        public Decimal heading
        {
            get;
            set;
        }

        [DataMember]
        public Decimal speed
        {
            get;
            set;
        }
    }
}
