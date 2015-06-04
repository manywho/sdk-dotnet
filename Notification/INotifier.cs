using System;
using System.Collections.Generic;
using ManyWho.Flow.SDK.Security;

namespace ManyWho.Flow.SDK.Utils
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

        String Reason
        {
            get;
            set;
        }

        void AddLogEntry(String entry);

        void AddNotificationMessage(String mediaType, String message);

        void SendNotification();

        void SendNotification(IAuthenticatedWho receivingAuthenticatedWho);

        void SendNotification(IAuthenticatedWho receivingAuthenticatedWho, String reason, String mediaType, String message);
    }
}
