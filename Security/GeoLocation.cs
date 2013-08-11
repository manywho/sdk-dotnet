using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Security
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class GeoLocation : IGeoLocation
    {
        [DataMember]
        public DateTime TimeStamp
        {
            get;
            set;
        }

        [DataMember]
        public Decimal Latitude
        {
            get;
            set;
        }

        [DataMember]
        public Decimal Longitude
        {
            get;
            set;
        }

        [DataMember]
        public Decimal Accuracy
        {
            get;
            set;
        }

        [DataMember]
        public Decimal Altitude
        {
            get;
            set;
        }

        [DataMember]
        public Decimal AltitudeAccuracy
        {
            get;
            set;
        }

        [DataMember]
        public Decimal Heading
        {
            get;
            set;
        }

        [DataMember]
        public Decimal Speed
        {
            get;
            set;
        }
    }
}
