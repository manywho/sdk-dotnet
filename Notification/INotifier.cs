using System.Collections.Generic;

namespace ManyWho.Flow.SDK.Notification
{
    public interface INotifier
    {
        List<INotificationMessage> NotificationMessages
        {
            get;
            set;
        }

        string Reason
        {
            get;
            set;
        }
    }
}
