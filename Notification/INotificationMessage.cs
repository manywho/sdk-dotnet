using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
