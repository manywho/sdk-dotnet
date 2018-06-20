using System;

namespace ManyWho.Flow.SDK.Notification
{
    public interface INotificationMessage
    {
        string MediaType
        {
            get;
            set;
        }

        string Message
        {
            get;
            set;
        }
    }
}
