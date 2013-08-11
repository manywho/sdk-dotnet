using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;

/*!

Copyright 2013 Manywho, Inc.

Licensed under the Manywho License, Version 1.0 (the "License"); you may not use this
file except in compliance with the License.

You may obtain a copy of the License at: http://manywho.com/sharedsource

Unless required by applicable law or agreed to in writing, software distributed under
the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the specific language governing
permissions and limitations under the License.

*/

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
