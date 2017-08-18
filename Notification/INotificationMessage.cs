using System;

namespace ManyWho.Flow.SDK.Utils
{
    public interface INotificationMessage
    {
        String MediaType
        {
            get;
            set;
        }

        String Message
        {
            get;
            set;
        }
    }
}
