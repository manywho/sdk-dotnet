using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using ManyWho.Flow.SDK.Run;
using ManyWho.Flow.SDK.Run.Elements.Type;
using ManyWho.Flow.SDK.Draw.Elements.Type;

namespace ManyWho.Flow.SDK.Utils
{
    public class ValueUtils
    {
        public static String GetContentValue(String developerName, List<EngineValueAPI> engineValues, Boolean required)
        {
            String contentValue = null;

            // Get the message input
            if (engineValues != null &&
                engineValues.Count > 0)
            {
                // Go through the inputs to find the message
                foreach (EngineValueAPI engineValue in engineValues)
                {
                    // Check to see if this is the post
                    if (engineValue.developerName.Equals(developerName, StringComparison.InvariantCultureIgnoreCase) == true)
                    {
                        // Grab the message
                        contentValue = engineValue.contentValue;

                        // Break out of this loop
                        break;
                    }
                }
            }

            if (required == true &&
                (contentValue == null ||
                 contentValue.Trim().Length == 0))
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.BadRequest, developerName + " cannot be null or blank.");
            }

            return contentValue;
        }

        public static ObjectAPI GetObjectData(String developerName, List<EngineValueAPI> engineValues, Boolean required)
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
                    if (engineValue.developerName.Equals(developerName, StringComparison.InvariantCultureIgnoreCase) == true)
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

            if (required == true &&
                objectData == null)
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.BadRequest, developerName + " cannot be null.");
            }

            return objectData;
        }

        public static List<ObjectAPI> GetListData(String developerName, List<EngineValueAPI> engineValues, Boolean required)
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
                    if (engineValue.developerName.Equals(developerName, StringComparison.InvariantCultureIgnoreCase) == true)
                    {
                        // Grab the message
                        objectData = engineValue.objectData;

                        // Break out of this loop
                        break;
                    }
                }
            }

            if (required == true &&
                (objectData == null ||
                 objectData.Count == 0))
            {
                throw ErrorUtils.GetWebException(HttpStatusCode.BadRequest, developerName + " cannot be null or empty.");
            }

            return objectData;
        }

        public static String SerializeListData(List<ObjectAPI> objectAPIs, TypeElementResponseAPI typeElementResponse)
        {
            String xml = null;

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

        public static String SerializeObjectData(ObjectAPI objectAPI, TypeElementResponseAPI typeElementResponse)
        {
            String xml = null;
            String internalId = null;
            String externalId = null;

            if (objectAPI.internalId != null &&
                objectAPI.internalId.Trim().Length > 0)
            {
                internalId = objectAPI.internalId;
            }
            else
            {
                internalId = Guid.NewGuid().ToString();
            }

            if (objectAPI.externalId != null &&
                objectAPI.externalId.Trim().Length > 0)
            {
                externalId = objectAPI.externalId;
            }
            else
            {
                externalId = Guid.NewGuid().ToString();
            }

            xml = "";
            xml += "<complextype internalid=\"" + internalId + "\" externalid=\"" + externalId + "\" typeelementid=\"" + typeElementResponse.id + "\">";

            if (objectAPI.properties != null &&
                objectAPI.properties.Count > 0)
            {
                foreach (PropertyAPI propertyAPI in objectAPI.properties)
                {
                    Boolean typeElementEntryFound = false;
                    String typeElementEntryId = null;
                    String contentType = null;

                    if (typeElementResponse.properties != null &&
                        typeElementResponse.properties.Count > 0)
                    {
                        foreach (TypeElementPropertyAPI typeElementEntryAPI in typeElementResponse.properties)
                        {
                            if (typeElementEntryAPI.developerName.Equals(propertyAPI.developerName, StringComparison.InvariantCultureIgnoreCase) == true)
                            {
                                typeElementEntryId = typeElementEntryAPI.id;
                                contentType = typeElementEntryAPI.contentType;

                                typeElementEntryFound = true;
                                break;
                            }
                        }
                    }

                    if (typeElementEntryFound == false)
                    {
                        ErrorUtils.GetWebException(HttpStatusCode.BadRequest, "Type element entry could not be found.");
                    }

                    xml += "<complextypeentry typeelemententryid=\"" + typeElementEntryId + "\" contenttype=\"" + contentType + "\">";

                    if (contentType.Equals(ManyWhoConstants.CONTENT_TYPE_OBJECT, StringComparison.InvariantCultureIgnoreCase) == true)
                    {
                        ErrorUtils.GetWebException(HttpStatusCode.BadRequest, "Object properties not supported yet.");
                    }
                    else if (contentType.Equals(ManyWhoConstants.CONTENT_TYPE_LIST, StringComparison.InvariantCultureIgnoreCase) == true)
                    {
                        ErrorUtils.GetWebException(HttpStatusCode.BadRequest, "List properties not supported yet.");
                    }
                    else
                    {
                        // Wrap primitive values in cdata so we don't screw up the xml document with invalid markup
                        xml += "<![CDATA[" + propertyAPI.contentValue + "]]>";
                    }

                    xml += "</complextypeentry>";
                }
            }

            xml += "</complextype>";

            return xml;
        }
    }
}
