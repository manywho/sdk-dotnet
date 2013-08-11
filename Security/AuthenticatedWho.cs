using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ManyWho.Flow.SDK.Security
{
    [DataContract(Namespace = "http://www.manywho.com/api")]
    public class AuthenticatedWho : IAuthenticatedWho
    {
        [DataMember]
        public Guid ManyWhoUserId
        {
            get;
            set;
        }

        [DataMember]
        public Guid ManyWhoTenantId
        {
            get;
            set;
        }

        [DataMember]
        public String ManyWhoToken
        {
            get;
            set;
        }

        [DataMember]
        public IGeoLocation GeoLocation
        {
            get;
            set;
        }

        [DataMember]
        public String UserId
        {
            get;
            set;
        }

        [DataMember]
        public String Email
        {
            get;
            set;
        }

        [DataMember]
        public String IdentityProvider
        {
            get;
            set;
        }

        [DataMember]
        public String Token
        {
            get;
            set;
        }

        [DataMember]
        public String TenantName
        {
            get;
            set;
        }

        [DataMember]
        public String DirectoryName
        {
            get;
            set;
        }

        [DataMember]
        public String DirectoryId
        {
            get;
            set;
        }
    }
}
