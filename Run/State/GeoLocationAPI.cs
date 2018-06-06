using System;
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

namespace ManyWho.Flow.SDK.Run.State
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class GeoLocationAPI
    {
        /// <summary>
        /// The latitude coordinate of the user's location.
        /// </summary>
        [DataMember]
        public decimal latitude
        {
            get;
            set;
        }

        /// <summary>
        /// The longitude coordinate of the user's location.
        /// </summary>
        [DataMember]
        public decimal longitude
        {
            get;
            set;
        }

        /// <summary>
        /// The accuracy of the location data that has been collected.
        /// </summary>
        [DataMember]
        public decimal accuracy
        {
            get;
            set;
        }

        /// <summary>
        /// The altitude of the user above mean sea level.
        /// </summary>
        [DataMember]
        public decimal altitude
        {
            get;
            set;
        }

        /// <summary>
        /// The accuracy of the altitude data that has been collected.
        /// </summary>
        [DataMember]
        public decimal altitudeAccuracy
        {
            get;
            set;
        }

        /// <summary>
        /// The heading of the user as degrees clockwise from North.
        /// </summary>
        [DataMember]
        public decimal heading
        {
            get;
            set;
        }

        /// <summary>
        /// The speed of the user in meters per second.
        /// </summary>
        [DataMember]
        public decimal speed
        {
            get;
            set;
        }

        /// <summary>
        /// The timestamp of the data that has been collected
        /// </summary>
        [DataMember]
        public DateTimeOffset time
        {
            get;
            set;
        }
    }
}
