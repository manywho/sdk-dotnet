using System;

namespace ManyWho.Flow.SDK.Notification
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
