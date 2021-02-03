using System;

namespace ManyWho.Flow.SDK.Security
{
    public interface IGroup
    {
        string Id
        {
            get;
            set;
        }

        string Name
        {
            get;
            set;
        }
    }
}
