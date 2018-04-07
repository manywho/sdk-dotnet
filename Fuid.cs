using System;

namespace ManyWho.Flow.SDK
{
    public static class Fuid
    {
        private static bool _reflowMode;
        
        public static bool ReflowMode { set =>  _reflowMode = value; }

        public static Guid NewGuid()
        {
            Guid newGuid = Guid.NewGuid();

            if (_reflowMode)
            {
                newGuid = Guid.Parse( newGuid.ToString("N").Substring(0, 26) + "ffffff" );
            }
            
            return newGuid;
        }
    }
}