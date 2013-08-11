using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Run.Elements.Config
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class AuthorizationAPI
    {
        [DataMember]
        public List<UserAPI> users
        {
            get;
            set;
        }

        [DataMember]
        public List<GroupAPI> groups
        {
            get;
            set;
        }

        [DataMember]
        public String runningAuthenticationId
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
    }
}
