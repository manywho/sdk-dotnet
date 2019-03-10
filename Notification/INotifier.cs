using System.Collections.Generic;
using ManyWho.Flow.SDK.Security;

namespace ManyWho.Flow.SDK.Notification
{
    public interface INotifier
    {
        IAuthenticatedWho ReceivingAuthenticatedWho
        {
            get;
            set;
        }

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
