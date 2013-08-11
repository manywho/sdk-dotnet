using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Security
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class AuthenticationCredentialsAPI
    {
        [DataMember]
        public String username
        {
            get;
            set;
        }

        [DataMember]
        public String password
        {
            get;
            set;
        }

        [DataMember]
        public String token
        {
            get;
            set;
        }

        [DataMember]
        public String sessionToken
        {
            get;
            set;
        }

        [DataMember]
        public String sessionUrl
        {
            get;
            set;
        }

        [DataMember]
        public String loginUrl
        {
            get;
            set;
        }
    }
}
