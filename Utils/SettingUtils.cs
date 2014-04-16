//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Net;
//using System.Configuration;
//using System.Threading.Tasks;
//using ManyWho.Flow.SDK.Describe;
//using ManyWho.Flow.SDK.Run;
//using ManyWho.Flow.SDK.Run.Elements.Config;

///*!

//Copyright 2013 Manywho, Inc.

//Licensed under the Manywho License, Version 1.0 (the "License"); you may not use this
//file except in compliance with the License.

//You may obtain a copy of the License at: http://manywho.com/sharedsource

//Unless required by applicable law or agreed to in writing, software distributed under
//the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
//KIND, either express or implied. See the License for the specific language governing
//permissions and limitations under the License.

//*/

//namespace ManyWho.Flow.SDK.Utils
//{
//    public class SettingUtils
//    {
//        public static String GetStringSetting(String setting)
//        {
//            return ConfigurationManager.AppSettings.Get(setting);
//        }

//        public static Boolean GetBooleanSetting(String setting)
//        {
//            Boolean booleanValue = false;
//            String value = null;

//            value = GetStringSetting(setting);

//            Boolean.TryParse(value, out booleanValue);

//            return booleanValue;
//        }

//        public static String GetConfigurationValue(String developerName, List<EngineValueAPI> configurationValues)
//        {
//            return GetConfigurationValue(developerName, configurationValues, false);
//        }

//        public static String GetConfigurationValue(String developerName, List<EngineValueAPI> configurationValues, Boolean required)
//        {
//            String value = null;

//            if (configurationValues != null &&
//                configurationValues.Count > 0)
//            {
//                foreach (EngineValueAPI configurationValue in configurationValues)
//                {
//                    if (developerName.Equals(configurationValue.developerName, StringComparison.InvariantCultureIgnoreCase) == true)
//                    {
//                        value = configurationValue.contentValue;
//                        break;
//                    }
//                }
//            }

//            if (required == true &&
//                (value == null ||
//                 value.Trim().Length == 0))
//            {
//                throw ErrorUtils.GetWebException(HttpStatusCode.BadRequest, developerName + " cannot be null or blank.");
//            }

//            return value;
//        }
//    }
//}
