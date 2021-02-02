using System.Collections.Generic;

namespace ManyWho.Flow.SDK.Tenant
{
    public class UserAPI : UserMeAPI
    {
        public string Role
        {
            get;
            set;
        }

        public bool IsSSO
        {
            get;
            set;
        }

        public List<UserTokenAPI> Tokens
        {
            get;
            set;
        }
    }
}
