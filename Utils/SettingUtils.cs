using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;

namespace ManyWho.Flow.SDK.Utils
{
    public class SettingUtils
    {
        public static String GetStringSetting(String setting)
        {
            return CloudConfigurationManager.GetSetting(setting);
        }

        public static Boolean GetBooleanSetting(String setting)
        {
            Boolean booleanValue = false;
            String value = null;

            value = GetStringSetting(setting);

            Boolean.TryParse(value, out booleanValue);

            return booleanValue;
        }
    }
}
