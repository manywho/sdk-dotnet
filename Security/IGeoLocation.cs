using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManyWho.Flow.SDK.Security
{
    public interface IGeoLocation
    {
        DateTime TimeStamp
        {
            get;
            set;
        }

        Decimal Latitude
        {
            get;
            set;
        }

        Decimal Longitude
        {
            get;
            set;
        }

        Decimal Accuracy
        {
            get;
            set;
        }

        Decimal Altitude
        {
            get;
            set;
        }

        Decimal AltitudeAccuracy
        {
            get;
            set;
        }

        Decimal Heading
        {
            get;
            set;
        }

        Decimal Speed
        {
            get;
            set;
        }
    }
}
