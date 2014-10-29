using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManyWho.Flow.SDK.Draw.Log
{
    [Flags]
    public enum LoggingLevel : ulong
    {
        Info = 0x1,
        Debug = Info | 0x100
    }
}
