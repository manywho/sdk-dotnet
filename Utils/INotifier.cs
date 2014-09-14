using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManyWho.Flow.SDK.Security;

namespace ManyWho.Flow.SDK.Utils
{
    public interface INotifier
    {
        String Reason
        {
            get;
            set;
        }

        void AddNotificationMessage(String mediaType, String message);

        void SendNotification();

        void SendNotification(IAuthenticatedWho receivingAuthenticatedWho);

        void SendNotification(IAuthenticatedWho receivingAuthenticatedWho, String reason, String mediaType, String message);
    }
}
