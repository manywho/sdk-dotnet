using System;
using System.Collections.Generic;
using ManyWho.Flow.SDK.Run;
using ManyWho.Flow.SDK.Run.Elements.Type;

namespace ManyWho.Flow.SDK.Utils
{
    public class ValueUtils
    {
        public static Guid ParseGuid(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || value == "blank")
            {
                return Guid.Empty;
            }
            
            return Guid.Parse(value);
        }

        public static Guid GetContentValueGuid(string developerName, List<EngineValueAPI> engineValues, bool required)
        {
            var value = GetContentValue(developerName, engineValues, required);

            return ParseGuid(value);
        }

        public static string GetContentValue(string developerName, List<EngineValueAPI> engineValues, bool required)
        {
            string contentValue = null;

            // Get the message input
            if (engineValues != null &&
                engineValues.Count > 0)
            {
                // Go through the inputs to find the message
                foreach (EngineValueAPI engineValue in engineValues)
                {
                    // Check to see if this is the post
                    if (engineValue.developerName.Equals(developerName, StringComparison.OrdinalIgnoreCase))
                    {
                        // Grab the message
                        contentValue = engineValue.contentValue;

                        // Break out of this loop
                        break;
                    }
                }
            }

            if (required &&
                string.IsNullOrWhiteSpace(contentValue))
            {
                throw new ArgumentNullException("contentValue", developerName + " cannot be null or blank.");
            }

            return contentValue;
        }

        public static string GetContentValueTrimmed(string developerName, List<EngineValueAPI> engineValues, bool required)
        {
            string value = GetContentValue(developerName, engineValues, required);
            
            return value != null ? value.Trim() : null;
        }

        public static List<ObjectAPI> GetObjectData(string developerName, ObjectAPI objectData, bool required)
        {
            List<ObjectAPI> listData = null;

            if (objectData != null &&
                objectData.properties != null &&
                objectData.properties.Count > 0)
            {
                foreach (PropertyAPI property in objectData.properties)
                {
                    if (property.developerName.Equals(developerName, StringComparison.OrdinalIgnoreCase))
                    {
                        listData = property.objectData;
                        break;
                    }
                }
            }

            if (required && 
                (listData == null || listData.Count == 0))
            {
                throw new ArgumentException("listData", developerName + " cannot be null.");
            }

            return listData;
        }

        public static ObjectAPI GetObjectData(string developerName, List<EngineValueAPI> engineValues, bool required)
        {
            ObjectAPI objectData = null;

            // Get the message input
            if (engineValues != null &&
                engineValues.Count > 0)
            {
                // Go through the inputs to find the message
                foreach (EngineValueAPI engineValue in engineValues)
                {
                    // Check to see if this is the post
                    if (engineValue.developerName.Equals(developerName, StringComparison.OrdinalIgnoreCase))
                    {
                        // Grab the message
                        if (engineValue.objectData != null &&
                            engineValue.objectData.Count > 0)
                        {
                            objectData = engineValue.objectData[0];
                        }

                        // Break out of this loop
                        break;
                    }
                }
            }

            if (required &&
                objectData == null)
            {
                throw new ArgumentNullException("objectData", developerName + " cannot be null.");
            }

            return objectData;
        }
    }
}
