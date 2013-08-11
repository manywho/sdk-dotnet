using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Elements.Group
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class GroupElementAPI : ElementAPI
    {
        [DataMember]
        public String id
        {
            get;
            set;
        }

        [DataMember]
        public String groupElementId
        {
            get;
            set;
        }

        [DataMember]
        public Int32 x
        {
            get;
            set;
        }

        [DataMember]
        public Int32 y
        {
            get;
            set;
        }

        [DataMember]
        public Int32 height
        {
            get;
            set;
        }

        [DataMember]
        public Int32 width
        {
            get;
            set;
        }

        [DataMember]
        public GroupAuthorizationAPI authorization
        {
            get;
            set;
        }
    }
}
