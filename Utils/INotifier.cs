using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManyWho.Flow.SDK.Utils
{
    public interface INotifier
    {
        String Reason
        {
            get;
            set;
        }

        String Description
        {
            get;
            set;
        }

        String CodeReference
        {
            get;
            set;
        }

        void SendNotification();
    }
}
