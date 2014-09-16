using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        void AddNotificationMessage(String mediaType, String message);

        Guid SendNotification();

        Guid SendNotification(IAuthenticatedWho receivingAuthenticatedWho);

        Guid SendNotification(IAuthenticatedWho receivingAuthenticatedWho, String reason, String mediaType, String message);
    }
}
