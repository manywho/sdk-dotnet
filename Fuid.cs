using System;

namespace ManyWho.Flow.SDK
{
    public static class Fuid
    {        
        public static bool ReflowEnabled { private get; set; }

        public static Guid NewGuid()
        {
            Guid newGuid = Guid.NewGuid();

            if (ReflowEnabled)
            {
                newGuid = Guid.Parse( newGuid.ToString("N").Substring(0, 26) + "ffffff" );
            }
            
            return newGuid;
        }
    }
}