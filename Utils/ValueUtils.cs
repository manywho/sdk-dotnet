using System;
using System.Collections.Generic;
using ManyWho.Flow.SDK.Draw.Elements.Type;
using ManyWho.Flow.SDK.Run;
using ManyWho.Flow.SDK.Run.Elements.Type;

namespace ManyWho.Flow.SDK.Utils
{
    public class ValueUtils
    {
        public static string GetContentValue(string developerName, ObjectAPI objectData, bool required)
        {
            string contentValue = null;

            if (objectData != null &&
                objectData.properties != null &&
                objectData.properties.Count > 0)
            {
                foreach (PropertyAPI property in objectData.properties)
                {
                    if (property.developerName.Equals(developerName, StringComparison.OrdinalIgnoreCase))
                    {
                        contentValue = property.contentValue;
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

        public static List<ObjectAPI> GetListData(string developerName, List<EngineValueAPI> engineValues, bool required)
        {
            List<ObjectAPI> objectData = null;

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
                        objectData = engineValue.objectData;

                        // Break out of this loop
                        break;
                    }
                }
            }

            if (required &&
                (objectData == null ||
                 objectData.Count == 0))
            {
                throw new ArgumentException("objectData", developerName + " cannot be null or empty.");
            }

            return objectData;
        }

        public static string SerializeListData(List<ObjectAPI> objectAPIs, TypeElementResponseAPI typeElementResponse)
        {
            string xml = null;

            if (objectAPIs != null &&
                objectAPIs.Count > 0)
            {
                xml += "<list currentpointer=\"0\">";

                // Go through each object and serialize it into the list
                foreach (ObjectAPI objectAPI in objectAPIs)
                {
                    xml += SerializeObjectData(objectAPI, typeElementResponse);
                }

                xml += "</list>";
            }

            return xml;
        }

        public static string SerializeObjectData(ObjectAPI objectAPI, TypeElementResponseAPI typeElementResponse)
        {
            string xml = null;
            string internalId = null;
            string externalId = null;

            if (objectAPI.internalId != null &&
                objectAPI.internalId.Trim().Length > 0)
            {
                internalId = objectAPI.internalId;
            }
            else
            {
                internalId = Fuid.NewGuid().ToString();
            }

            if (objectAPI.externalId != null &&
                objectAPI.externalId.Trim().Length > 0)
            {
                externalId = objectAPI.externalId;
            }
            else
            {
                externalId = Fuid.NewGuid().ToString();
            }

            xml = "";
            xml += "<complextype internalid=\"" + internalId + "\" externalid=\"" + externalId + "\" typeelementid=\"" + typeElementResponse.id + "\">";

            if (objectAPI.properties != null &&
                objectAPI.properties.Count > 0)
            {
                foreach (PropertyAPI propertyAPI in objectAPI.properties)
                {
                    bool typeElementEntryFound = false;
                    string typeElementEntryId = null;
                    string contentType = null;

                    if (typeElementResponse.properties != null &&
                        typeElementResponse.properties.Count > 0)
                    {
                        foreach (TypeElementPropertyAPI typeElementEntryAPI in typeElementResponse.properties)
                        {
                            if (typeElementEntryAPI.developerName.Equals(propertyAPI.developerName, StringComparison.OrdinalIgnoreCase))
                            {
                                typeElementEntryId = typeElementEntryAPI.id;
                                contentType = typeElementEntryAPI.contentType;

                                typeElementEntryFound = true;
                                break;
                            }
                        }
                    }

                    Validation.Instance.IsTrue(typeElementEntryFound, "TypeElementEntry", "Type element entry could not be found.");
                    
                    xml += "<complextypeentry typeelemententryid=\"" + typeElementEntryId + "\" contenttype=\"" + contentType + "\">";

                    if (contentType.Equals(ManyWhoConstants.CONTENT_TYPE_OBJECT, StringComparison.OrdinalIgnoreCase))
                    {
                        throw new ArgumentException("contentType", "Object properties not supported yet.");
                    }

                    if (contentType.Equals(ManyWhoConstants.CONTENT_TYPE_LIST, StringComparison.OrdinalIgnoreCase))
                    {
                        throw new ArgumentException("contentType", "List properties not supported yet.");
                    }

                    // Wrap primitive values in cdata so we don't screw up the xml document with invalid markup
                    xml += "<![CDATA[" + propertyAPI.contentValue + "]]>";

                    xml += "</complextypeentry>";
                }
            }

            xml += "</complextype>";

            return xml;
        }
    }
}
