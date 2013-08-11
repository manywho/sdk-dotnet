using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Draw.Elements.Group
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class GroupAuthorizationAPI
    {
        [DataMember]
        public String serviceElementId
        {
            get;
            set;
        }

        [DataMember]
        public String globalAuthenticationType
        {
            get;
            set;
        }

        [DataMember]
        public String streamBehaviour
        {
            get;
            set;
        }

        [DataMember]
        public List<GroupAuthorizationGroupAPI> groups
        {
            get;
            set;
        }

        [DataMember]
        public List<GroupAuthorizationUserAPI> users
        {
            get;
            set;
        }

        [DataMember]
        public List<GroupAuthorizationLocationAPI> locations
        {
            get;
            set;
        }
    }
}
