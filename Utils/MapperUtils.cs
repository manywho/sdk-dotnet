using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using ManyWho.Flow.SDK;
using ManyWho.Flow.SDK.Draw.Elements.Type;
using ManyWho.Flow.SDK.Draw.Elements.Value;
using ManyWho.Flow.SDK.Run.Elements.Type;
using ManyWho.Flow.SDK.Draw.Elements;

namespace ManyWho.Flow.SDK
{
    public class MapperUtils
    {
        public static String Convert<T>(Dictionary<String, TypeElementRequestAPI> typeElementRequestAPIs)
        {
            if (typeElementRequestAPIs == null)
            {
                throw new ArgumentNullException("TypeElementRequestAPIs", "The provided Dictionary cannot be null.");
            }
 
            return Convert(typeof(T), typeElementRequestAPIs);
        }

        public static List<T> Convert<T>(List<ObjectAPI> objectAPIs)
        {
            List<T> list = null;

            if (objectAPIs != null &&
                objectAPIs.Count > 0)
            {
                String typeName = GetCleanObjectName(typeof(T).Name);

                foreach (ObjectAPI objectAPI in objectAPIs)
                {
                    if (objectAPI.developerName.Equals(typeName, StringComparison.OrdinalIgnoreCase) == false)
                    {
                        throw new ArgumentNullException("ObjectAPI", String.Format("The provided list contains inconsistent objects. The Draw API expected {0} and it got {1}", typeName, objectAPI.developerName));
                    }

                    if (objectAPI.properties != null &&
                        objectAPI.properties.Count > 0)
                    {
                        // Create an instance of the typed object so we can fill it up with data
                        T typedObject = (T)Activator.CreateInstance(typeof(T));

                        // Grab the properties from the type so we can assign them from the incoming object api properties
                        PropertyInfo[] propertyInfosFromType = typeof(T).GetProperties();

                        // Go through the properties in the incoming data first as this may be a sub-set
                        foreach (PropertyAPI propertyAPI in objectAPI.properties)
                        {
                            // Now go through the properties in the object to see if we have a matching one
                            for (int i = 0; i < propertyInfosFromType.Length; i++)
                            {
                                PropertyInfo propertyInfoFromType = propertyInfosFromType[i];

                                // Check to see if this is the matching property in the type
                                if (GetCleanPropertyName(propertyInfoFromType.Name).Equals(propertyAPI.developerName, StringComparison.OrdinalIgnoreCase) == true)
                                {
                                    // The the property from the object, but only if it's public
                                    PropertyInfo propertyInfo = typedObject.GetType().GetProperty(propertyInfoFromType.Name, BindingFlags.Public | BindingFlags.Instance);

                                    // Check to make sure we found one and that we can write to it
                                    if (propertyInfo != null &&
                                        propertyInfo.CanWrite == true)
                                    {
                                        // Convert the property over correctly for the object property
                                        if (propertyInfo.PropertyType.Name.Equals(typeof(String).Name, StringComparison.OrdinalIgnoreCase) == true)
                                        {
                                            propertyInfo.SetValue(typedObject, propertyAPI.contentValue, null);
                                        }
                                        else if (propertyInfo.PropertyType.Name.Equals(typeof(Guid).Name, StringComparison.OrdinalIgnoreCase) == true)
                                        {
                                            if (string.IsNullOrWhiteSpace(propertyAPI.contentValue) == false)
                                            {
                                                Guid guid = Guid.Empty;

                                                if (Guid.TryParse(propertyAPI.contentValue, out guid) == true)
                                                {
                                                    propertyInfo.SetValue(typedObject, guid, null);
                                                }
                                                else
                                                {
                                                    throw new ArgumentNullException("ObjectAPI.PropertyAPI", string.Format("The property value provided is not a valid Guid. The property being assigned is: '{0}'. The value provided is: '{1}'", propertyAPI.developerName, propertyAPI.contentValue));
                                                }
                                            }
                                        }
                                        else if (propertyInfo.PropertyType.Name.Equals(typeof(Int32).Name, StringComparison.OrdinalIgnoreCase) == true)
                                        {
                                            if (string.IsNullOrWhiteSpace(propertyAPI.contentValue) == false)
                                            {
                                                Int32 int32 = 0;

                                                if (Int32.TryParse(propertyAPI.contentValue, out int32) == true)
                                                {
                                                    propertyInfo.SetValue(typedObject, int32, null);
                                                }
                                                else
                                                {
                                                    throw new ArgumentNullException("ObjectAPI.PropertyAPI", string.Format("The property value provided is not a valid Number. The property being assigned is: '{0}'. The value provided is: '{1}'", propertyAPI.developerName, propertyAPI.contentValue));
                                                }
                                            }
                                        }
                                        else if (propertyInfo.PropertyType.Name.Equals(typeof(DateTime).Name, StringComparison.OrdinalIgnoreCase) == true)
                                        {
                                            if (string.IsNullOrWhiteSpace(propertyAPI.contentValue) == false)
                                            {
                                                DateTime dateTime = DateTime.Now;

                                                if (DateTime.TryParse(propertyAPI.contentValue, out dateTime) == true)
                                                {
                                                    propertyInfo.SetValue(typedObject, dateTime, null);
                                                }
                                                else
                                                {
                                                    throw new ArgumentNullException("ObjectAPI.PropertyAPI", string.Format("The property value provided is not a valid DateTime. The property being assigned is: '{0}'. The value provided is: '{1}'", propertyAPI.developerName, propertyAPI.contentValue));
                                                }
                                            }
                                        }
                                        else if (propertyInfo.PropertyType.Name.Equals(typeof(Boolean).Name, StringComparison.OrdinalIgnoreCase) == true)
                                        {
                                            if (string.IsNullOrWhiteSpace(propertyAPI.contentValue) == false)
                                            {
                                                Boolean boolean = false;

                                                if (Boolean.TryParse(propertyAPI.contentValue, out boolean) == true)
                                                {
                                                    propertyInfo.SetValue(typedObject, boolean, null);
                                                }
                                                else
                                                {
                                                    throw new ArgumentNullException("ObjectAPI.PropertyAPI", string.Format("The property value provided is not a valid Boolean. The property being assigned is: '{0}'. The value provided is: '{1}'", propertyAPI.developerName, propertyAPI.contentValue));
                                                }
                                            }
                                        }
                                        else
                                        {
                                            // As an extra check, we make sure the name of the type ends with API or we may have a non-converted primitive property
                                            if (propertyInfo.PropertyType.Name.EndsWith("API", StringComparison.OrdinalIgnoreCase) == false)
                                            {
                                                throw new NotImplementedException(propertyInfo.PropertyType.Name);
                                            }

                                            if (propertyInfo.PropertyType.Name.Equals("ValueElementIdAPI", StringComparison.OrdinalIgnoreCase) == true)
                                            {
                                                // This is a value element id so we convert it to a full reference so we have naming information, etc
                                                //typeElementPropertyAPI.typeElementDeveloperName = Convert<ValueElementIdReferenceAPI>(typeElementRequestAPIs);
                                            }
                                            else
                                            {
                                                // The property is an object, so we convert that over here so we have the type
                                                //propertyInfo.SetValue(Convert(propertyInfo.PropertyType, typeElementRequestAPIs));
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return list;
        }

        private static String Convert(Type type, Dictionary<String, TypeElementRequestAPI> typeElementRequestAPIs)
        {
            String name = GetCleanObjectName(type.Name);

            // If we've converted this type already, we just return the type name
            if (typeElementRequestAPIs.ContainsKey(name) == true)
            {
                return name;
            }

            TypeElementRequestAPI typeElementRequestAPI = new TypeElementRequestAPI();
            typeElementRequestAPI.developerName = name;
            typeElementRequestAPI.developerSummary = "Type for " + name + " Draw API objects.";
            typeElementRequestAPI.elementType = ManyWhoConstants.TYPE_ELEMENT_TYPE_IMPLEMENTATION_TYPE;
            typeElementRequestAPI.bindings = new List<TypeElementBindingAPI>();
            typeElementRequestAPI.properties = new List<TypeElementPropertyAPI>();

            TypeElementBindingAPI typeElementBindingAPI = new TypeElementBindingAPI();
            typeElementBindingAPI.databaseTableName = name;
            typeElementBindingAPI.developerName = name;
            typeElementBindingAPI.developerSummary = "Binding for " + name + " Draw API objects.";
            typeElementBindingAPI.propertyBindings = new List<TypeElementPropertyBindingAPI>();

            // Add the binding to the type request
            typeElementRequestAPI.bindings.Add(typeElementBindingAPI);

            // Set the type element request into our dictionary of types - so we don't accidentally repeat a developer name but also
            // so we don't get stuck in an infinite loop for self-referencing situations
            typeElementRequestAPIs[typeElementRequestAPI.developerName] = typeElementRequestAPI;

            // Get the properties for the root type
            foreach (PropertyInfo propertyInfo in type.GetProperties())
            {
                TypeElementPropertyAPI typeElementPropertyAPI = Convert(typeElementRequestAPIs, propertyInfo);
                if (typeElementPropertyAPI != null)
                {
                    TypeElementPropertyBindingAPI typeElementPropertyBindingAPI = new TypeElementPropertyBindingAPI();
                    typeElementPropertyBindingAPI.databaseContentType = typeElementPropertyAPI.contentType;
                    typeElementPropertyBindingAPI.databaseFieldName = typeElementPropertyAPI.developerName;
                    typeElementPropertyBindingAPI.typeElementPropertyDeveloperName = typeElementPropertyAPI.developerName;

                    // Add the property and binding
                    typeElementBindingAPI.propertyBindings.Add(typeElementPropertyBindingAPI);
                    typeElementRequestAPI.properties.Add(typeElementPropertyAPI);
                }
            }

            return typeElementRequestAPI.developerName;
        }

        public static ObjectAPI Convert<T>(String externalId, object source)
        {
            Type type = typeof(T);

            return Convert(type, externalId, source);
        }

        private static ObjectAPI Convert(Type type, String externalId, object source)
        {
            ObjectAPI objectAPI = null;

            if (source != null)
            {
                objectAPI = new ObjectAPI();
                objectAPI.developerName = GetCleanObjectName(type.Name);
                objectAPI.externalId = externalId;
                objectAPI.properties = new List<PropertyAPI>();

                foreach (PropertyInfo propertyInfo in type.GetProperties())
                {
                    PropertyAPI propertyAPI = Convert(source, propertyInfo);
                    if (propertyAPI != null)
                    {
                        objectAPI.properties.Add(propertyAPI);
                    }
                }
            }

            return objectAPI;
        }

        public static TypeElementPropertyAPI Convert(Dictionary<String, TypeElementRequestAPI> typeElementRequestAPIs, PropertyInfo propertyInfo)
        {
            if (typeof(Dictionary<String, String>).IsAssignableFrom(propertyInfo.PropertyType))
            {
                return GetTypeElementPropertyAPIFromDictionary(typeElementRequestAPIs, propertyInfo);
            }
            // string inherits from IEnumerable so add a check for "not string"
            else if (typeof(IEnumerable).IsAssignableFrom(propertyInfo.PropertyType) && 
                     propertyInfo.PropertyType != typeof(string))
            {
                return GetTypeElementPropertyAPIFromCollection(typeElementRequestAPIs, propertyInfo);
            }
            else
            {
                return GetTypeElementPropertyAPIFromType(typeElementRequestAPIs, propertyInfo);
            }
        }

        public static PropertyAPI Convert(object source, PropertyInfo propertyInfo)
        {
            if (typeof(IDictionary).IsAssignableFrom(propertyInfo.PropertyType))
            {
                return GetPropertyAPIFromDictionary(source, propertyInfo);
            }
            // string inherits from IEnumerable so add a check for "not string"
            else if (typeof(IEnumerable).IsAssignableFrom(propertyInfo.PropertyType) && 
                        propertyInfo.PropertyType != typeof(string))
            {
                return GetPropertyAPIFromCollection(source, propertyInfo);
            }
            else
            {
                return GetPropertyAPIFromType(source, propertyInfo);
            }
        }

        private static PropertyAPI GetPropertyAPIFromCollection(object source, PropertyInfo propertyInfo)
        {
            IEnumerable values = (IEnumerable)propertyInfo.GetValue(source, null);
            return GetPropertyAPIFromCollection(values, propertyInfo);
        }

        private static TypeElementPropertyAPI GetTypeElementPropertyAPIFromCollection(Dictionary<String, TypeElementRequestAPI> typeElementRequestAPIs, PropertyInfo propertyInfo)
        {
            TypeElementPropertyAPI typeElementPropertyAPI = null;
            Type type = propertyInfo.PropertyType;

            // Check to make sure it is a full on list
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>))
            {
                Type itemType = type.GetGenericArguments()[0];

                typeElementPropertyAPI = new TypeElementPropertyAPI();
                typeElementPropertyAPI.contentType = ManyWhoConstants.CONTENT_TYPE_LIST;
                typeElementPropertyAPI.developerName = GetCleanPropertyName(propertyInfo.Name);

                // This method returns the name of the root type - which we need here
                typeElementPropertyAPI.typeElementDeveloperName = Convert(itemType, typeElementRequestAPIs);
            }

            return typeElementPropertyAPI;
        }

        private static PropertyAPI GetPropertyAPIFromCollection(IEnumerable values, PropertyInfo propertyInfo)
        {
            List<ObjectAPI> objectAPIs = null;
            Type type = propertyInfo.PropertyType;

            // Check to make sure it is a full on list and get the type from the entries
            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>))
            {
                type = type.GetGenericArguments()[0];
            }

            if (values != null)
            {
                foreach (Object objectEntry in values)
                {
                    objectAPIs = new List<ObjectAPI>();

                    if (objectEntry is ElementAPI)
                    {
                        // Assign the identifier property from the object
                        objectAPIs.Add(Convert(type, ((ElementAPI)objectEntry).id, objectEntry));
                    }
                    else
                    {
                        // Assign a random external identifier
                        objectAPIs.Add(Convert(type, Guid.NewGuid().ToString(), objectEntry));
                    }
                }
            }

            return new PropertyAPI()
            {
                developerName = GetCleanPropertyName(propertyInfo.Name),
                objectData = objectAPIs,
                typeElementPropertyId = null
            };
        }

        private static TypeElementPropertyAPI GetTypeElementPropertyAPIFromDictionary(Dictionary<String, TypeElementRequestAPI> typeElementRequestAPIs, PropertyInfo propertyInfo)
        {
            TypeElementRequestAPI typeElementRequestAPI = null;
            TypeElementBindingAPI typeElementBindingAPI = null;
            TypeElementPropertyAPI typeElementPropertyAPI = null;
            String name = "KeyPair";

            typeElementPropertyAPI = new TypeElementPropertyAPI();
            typeElementPropertyAPI.developerName = GetCleanPropertyName(propertyInfo.Name);
            typeElementPropertyAPI.contentType = ManyWhoConstants.CONTENT_TYPE_LIST;
            typeElementPropertyAPI.typeElementDeveloperName = name;

            if (typeElementRequestAPIs.ContainsKey(name) == false)
            {
                // Now create the type for the key pair
                typeElementRequestAPI = new TypeElementRequestAPI();
                typeElementRequestAPI.developerName = name;
                typeElementRequestAPI.developerSummary = "Type for " + name + " Draw API objects.";
                typeElementRequestAPI.elementType = ManyWhoConstants.TYPE_ELEMENT_TYPE_IMPLEMENTATION_TYPE;
                typeElementRequestAPI.bindings = new List<TypeElementBindingAPI>();
                typeElementRequestAPI.properties = new List<TypeElementPropertyAPI>();
                typeElementRequestAPI.properties.Add(new TypeElementPropertyAPI()
                {
                    developerName = "Key",
                    contentType = ManyWhoConstants.CONTENT_TYPE_STRING,
                });
                typeElementRequestAPI.properties.Add(new TypeElementPropertyAPI()
                {
                    developerName = "Value",
                    contentType = ManyWhoConstants.CONTENT_TYPE_STRING,
                });

                typeElementBindingAPI = new TypeElementBindingAPI();
                typeElementBindingAPI.databaseTableName = name;
                typeElementBindingAPI.developerName = name;
                typeElementBindingAPI.developerSummary = "Binding for " + name + " Draw API objects.";
                typeElementBindingAPI.propertyBindings = new List<TypeElementPropertyBindingAPI>();
                typeElementBindingAPI.propertyBindings.Add(new TypeElementPropertyBindingAPI()
                {
                    databaseFieldName = "Key",
                    typeElementPropertyDeveloperName = "Key",
                    databaseContentType = ManyWhoConstants.CONTENT_TYPE_STRING
                });
                typeElementBindingAPI.propertyBindings.Add(new TypeElementPropertyBindingAPI()
                {
                    databaseFieldName = "Value",
                    typeElementPropertyDeveloperName = "Value",
                    databaseContentType = ManyWhoConstants.CONTENT_TYPE_STRING
                });

                // Add the binding to the type request
                typeElementRequestAPI.bindings.Add(typeElementBindingAPI);

                // Add this type element request
                typeElementRequestAPIs[typeElementRequestAPI.developerName] = typeElementRequestAPI;
            }

            return typeElementPropertyAPI;
        }

        private static PropertyAPI GetPropertyAPIFromDictionary(object source, PropertyInfo propertyInfo)
        {
            PropertyAPI propertyAPI = null;
            IDictionary value = (IDictionary)propertyInfo.GetValue(source, null);

            if (value != null)
            {
                propertyAPI = GetPropertyAPIFromCollection(value.Values, propertyInfo);
            }

            return propertyAPI;
        }

        private static PropertyAPI GetPropertyAPIFromComplexType(String externalId, object source, PropertyInfo propertyInfo)
        {
            object propertyValue = propertyInfo.GetValue(source, null);
            List<ObjectAPI> objectData = new List<ObjectAPI>();

            if (propertyValue != null)
            {
                objectData.Add(Convert(source.GetType(), externalId, propertyValue));
            }

            return new PropertyAPI()
            {
                developerName = GetCleanPropertyName(propertyInfo.Name),
                objectData = objectData,
                typeElementPropertyId = null
            };
        }

        private static TypeElementPropertyAPI GetTypeElementPropertyAPIFromType(Dictionary<String, TypeElementRequestAPI> typeElementRequestAPIs, PropertyInfo propertyInfo)
        {
            TypeElementPropertyAPI typeElementPropertyAPI = null;

            typeElementPropertyAPI = new TypeElementPropertyAPI();
            typeElementPropertyAPI.developerName = GetCleanPropertyName(propertyInfo.Name);

            if (propertyInfo.PropertyType.Name.Equals(typeof(String).Name, StringComparison.OrdinalIgnoreCase) == true ||
                propertyInfo.PropertyType.Name.Equals(typeof(Guid).Name, StringComparison.OrdinalIgnoreCase) == true)
            {
                typeElementPropertyAPI.contentType = ManyWhoConstants.CONTENT_TYPE_STRING;
            }
            else if (propertyInfo.PropertyType.Name.Equals(typeof(Int32).Name, StringComparison.OrdinalIgnoreCase) == true)
            {
                typeElementPropertyAPI.contentType = ManyWhoConstants.CONTENT_TYPE_NUMBER;
            }
            else if (propertyInfo.PropertyType.Name.Equals(typeof(DateTime).Name, StringComparison.OrdinalIgnoreCase) == true)
            {
                typeElementPropertyAPI.contentType = ManyWhoConstants.CONTENT_TYPE_DATETIME;
            }
            else if (propertyInfo.PropertyType.Name.Equals(typeof(Boolean).Name, StringComparison.OrdinalIgnoreCase) == true)
            {
                typeElementPropertyAPI.contentType = ManyWhoConstants.CONTENT_TYPE_BOOLEAN;
            }
            else
            {
                // As an extra check, we make sure the name of the type ends with API or we may have a non-converted primitive property
                if (propertyInfo.PropertyType.Name.EndsWith("API", StringComparison.OrdinalIgnoreCase) == false)
                {
                    throw new NotImplementedException(propertyInfo.PropertyType.Name);
                }

                if (propertyInfo.PropertyType.Name.Equals("ValueElementIdAPI", StringComparison.OrdinalIgnoreCase) == true)
                {
                    // This is a value element id so we convert it to a full reference so we have naming information, etc
                    typeElementPropertyAPI.typeElementDeveloperName = Convert<ValueElementIdReferenceAPI>(typeElementRequestAPIs);
                }
                else
                {
                    // The property is an object, so we convert that over here so we have the type
                    typeElementPropertyAPI.typeElementDeveloperName = Convert(propertyInfo.PropertyType, typeElementRequestAPIs);
                }

                typeElementPropertyAPI.contentType = ManyWhoConstants.CONTENT_TYPE_OBJECT;
            }

            return typeElementPropertyAPI;
        }

        private static PropertyAPI GetPropertyAPIFromType(object source, PropertyInfo propertyInfo)
        {
            object propertyValue = propertyInfo.GetValue(source, null);
            string value = null;

            if (propertyValue != null)
            {
                if (propertyValue is DateTime)
                {
                    value = ((DateTime)propertyValue).ToUniversalTime().ToString();
                }
                else
                {
                    value = propertyValue.ToString();
                }                
            }

            return new PropertyAPI()
            {
                developerName = GetCleanPropertyName(propertyInfo.Name),
                contentValue = value,
                objectData = null,
                typeElementPropertyId = null
            };
        }

        public static String GetTypeName<T>()
        {
            return GetCleanObjectName(typeof(T).Name);
        }

        private static String GetCleanPropertyName(String name)
        {
            // Make the first letter in the name uppercase
            name = char.ToUpper(name[0]) + name.Substring(1);

            return name;
        }

        private static String GetCleanObjectName(String name)
        {
            // Make the first letter in the name uppercase
            name = char.ToUpper(name[0]) + name.Substring(1);

            // Chop off the API bit at the end
            name = name.Substring(0, name.Length - 3);

            return name;
        }
    }
}
