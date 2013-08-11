using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

/*!

Copyright 2013 Manywho, Inc.

Licensed under the Manywho License, Version 1.0 (the "License"); you may not use this
file except in compliance with the License.

You may obtain a copy of the License at: http://manywho.com/sharedsource

Unless required by applicable law or agreed to in writing, software distributed under
the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the specific language governing
permissions and limitations under the License.

*/

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
