using System;

namespace ManyWho.Flow.SDK
{
    public static class Fuid
    {  
        public static Guid NewGuid()
        {
            Guid newGuid = Guid.NewGuid();            
            return newGuid;
        }
    }
}