using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK.Draw.Content;

namespace ManyWho.Flow.SDK.Draw.Elements.Type
{
    /// <summary>
    /// This object stores the configuration information we need to make object data requests as part of a map element request or
    /// as part of a form field.
    /// </summary>
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class ObjectDataRequestConfigAPI
    {
        /// <summary>
        /// The Id for the service element associated with this object data.  The service element will give us the connection settings
        /// and allow us to validate various info around the type.
        /// </summary>
        [DataMember]
        public String bindingId
        {
            get;
            set;
        }

        /// <summary>
        /// This will give us all of the object and field data we need to successfully make a request against the specified type.  We will
        /// pass the type properties etc so the called service can optimize around exactly what the user is asking for.
        /// </summary>
        [DataMember]
        public String typeElementId
        {
            get;
            set;
        }

        /// <summary>
        /// The filter to apply to the data at runtime.
        /// </summary>
        [DataMember]
        public ListFilterConfigAPI listFilter
        {
            get;
            set;
        }

        /// <summary>
        /// Any additional attributes to help with the object data request.
        /// </summary>
        [DataMember]
        public CommandAPI command
        {
            get;
            set;
        }
    }
}
