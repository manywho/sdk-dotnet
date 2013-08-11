using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Security
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class AuthenticatedWhoResultAPI
    {
        [DataMember]
        public String userId
        {
            get;
            set;
        }

        [DataMember]
        public String username
        {
            get;
            set;
        }

        [DataMember]
        public String directoryId
        {
            get;
            set;
        }

        [DataMember]
        public String directoryName
        {
            get;
            set;
        }

        [DataMember]
        public String tenantName
        {
            get;
            set;
        }

        [DataMember]
        public String identityProvider
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
        public String status
        {
            get;
            set;
        }

        [DataMember]
        public String statusMessage
        {
            get;
            set;
        }
    }
}
