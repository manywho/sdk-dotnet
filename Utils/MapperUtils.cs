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

        public static T Convert<T>(ObjectAPI objectApi)
        {
            return Convert<T>(new List<ObjectAPI> { objectApi }).FirstOrDefault();
        }

        public static List<T> Convert<T>(List<ObjectAPI> objectAPIs)
        {
            List<object> objectList = null;
            List<T> list = null;

            objectList = Convert(typeof(T), objectAPIs);

            // Convert the list to a typed list
            if (objectList != null &&
                objectList.Count > 0)
            {
                list = new List<T>();

                foreach (object objectEntry in objectList)
                {
                    list.Add((T)objectEntry);
                }
            }

            return list;
        }

        public static List<object> Convert(Type type, List<ObjectAPI> objectAPIs)
        {
            List<object> list = null;

            if (objectAPIs != null &&
                objectAPIs.Count > 0)
            {
                String typeName = GetCleanObjectName(type.Name);

                // Create the list to hold the translated objects
                list = new List<object>();

                foreach (ObjectAPI objectAPI in objectAPIs)
                {
                    // If we have a value element identifier, we need to translate it over
                    if (type.Name.Equals("ValueElementIdAPI", StringComparison.OrdinalIgnoreCase) == true)
                    {
                        type = new ValueElementIdReferenceAPI().GetType();
                    }
                    else if (objectAPI.developerName.Equals(typeName, StringComparison.OrdinalIgnoreCase) == false)
                    {
                        throw new ArgumentNullException("ObjectAPI", String.Format("The provided list contains inconsistent objects. The Draw API expected {0} and it got {1}", typeName, objectAPI.developerName));
                    }

                    if (objectAPI.properties != null &&
                        objectAPI.properties.Count > 0)
                    {
                        // Create an instance of the typed object so we can fill it up with data
                        object typedObject = Activator.CreateInstance(type);

                        // Grab the properties from the type so we can assign them from the incoming object api properties
                        IEnumerable<PropertyInfo> propertyInfosFromType = type.GetRuntimeProperties();

                        // Go through the properties in the incoming data first as this may be a sub-set
                        foreach (PropertyAPI propertyAPI in objectAPI.properties)
                        {
                            // Now go through the properties in the object to see if we have a matching one
                            for (int i = 0; i < propertyInfosFromType.Count(); i++)
                            {
                                PropertyInfo propertyInfoFromType = propertyInfosFromType.ElementAt(i);

                                // Check to see if this is the matching property in the type
                                if (GetCleanPropertyName(propertyInfoFromType.Name).Equals(propertyAPI.developerName, StringComparison.OrdinalIgnoreCase) == true)
                                {
                                    // The the property from the object, but only if it's public
                                    PropertyInfo propertyInfo = typedObject.GetType().GetRuntimeProperty(propertyInfoFromType.Name);

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
                                            // We have some form of object type, so we need to do some additional testing
                                            if (typeof(Dictionary<String, String>).GetTypeInfo().IsAssignableFrom(propertyInfo.PropertyType.GetTypeInfo()))
                                            {
                                                // Check if we're looking at the Attributes field and whether we have any
                                                if (propertyInfo.Name.Equals("attributes") && propertyAPI.objectData != null && propertyAPI.objectData.Count > 0)
                                                {
                                                    // If there are any attributes then map all of them into a Dictionary<string, string>
                                                    var attributes = propertyAPI.objectData.Where(o => o.developerName.Equals("KeyPair"))
                                                        .ToDictionary(
                                                            o =>
                                                            {
                                                                return o.properties.First(p => p.developerName.Equals("Key")).contentValue;
                                                            },
                                                            o =>
                                                            {
                                                                return o.properties.First(p => p.developerName.Equals("Value")).contentValue;
                                                            });

                                                    propertyInfo.SetValue(typedObject, attributes);
                                                }
                                            }
                                            // string inherits from IEnumerable so add a check for "not string"
                                            else if (typeof(IEnumerable).GetTypeInfo().IsAssignableFrom(propertyInfo.PropertyType.GetTypeInfo()) &&
                                                     propertyInfo.PropertyType != typeof(string))
                                            {
                                                Type itemType = null;

                                                // Check to make sure it is a full on list
                                                if (propertyInfo.PropertyType.GetTypeInfo().IsGenericType && propertyInfo.PropertyType.GetGenericTypeDefinition() == typeof(List<>))
                                                {
                                                    itemType = propertyInfo.PropertyType.GenericTypeArguments.ElementAt(0);
                                                }

                                                // As an extra check, we make sure the name of the type ends with API or we may have a non-converted primitive property
                                                if (itemType.Name.EndsWith("API", StringComparison.OrdinalIgnoreCase) == false)
                                                {
                                                    throw new NotImplementedException(propertyInfo.PropertyType.Name);
                                                }

                                                List<object> objectList = Convert(itemType, propertyAPI.objectData);
                                                IList typedList = null;

                                                if (objectList != null &&
                                                    objectList.Count > 0)
                                                {
                                                    var listType = typeof(List<>).MakeGenericType(itemType);
                                                    typedList = (IList)Activator.CreateInstance(listType);

                                                    foreach (object objectEntry in objectList)
                                                    {
                                                        typedList.Add(objectEntry);
                                                    }
                                                }

                                                propertyInfo.SetValue(typedObject, typedList, null);
                                            }
                                            else
                                            {
                                                // As an extra check, we make sure the name of the type ends with API or we may have a non-converted primitive property
                                                if (propertyInfo.PropertyType.Name.EndsWith("API", StringComparison.OrdinalIgnoreCase) == false)
                                                {
                                                    throw new NotImplementedException(propertyInfo.PropertyType.Name);
                                                }

                                                List<object> propertyList = Convert(propertyInfo.PropertyType, propertyAPI.objectData);

                                                // Check to make sure we converted something over
                                                if (propertyList != null &&
                                                    propertyList.Count > 0)
                                                {
                                                    foreach (var propertyObject in propertyList)
                                                    {
                                                        // Assign the first entry in the returned list
                                                        propertyInfo.SetValue(typedObject, propertyObject, null);
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        // Add the typed object to the list
                        list.Add(typedObject);
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
            foreach (PropertyInfo propertyInfo in type.GetRuntimeProperties())
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

        public static ObjectAPI Convert<T>(String externalId, object source, List<ValueElementIdReferenceAPI> valueElementIdReferences)
        {
            Type type = typeof(T);

            return Convert(type, externalId, source, valueElementIdReferences);
        }

        private static ObjectAPI Convert(Type type, String externalId, object source, List<ValueElementIdReferenceAPI> valueElementIdReferences)
        {
            ObjectAPI objectAPI = null;

            if (source != null)
            {
                // If we have a value element identifier, we need to translate it over
                if (type.Name.Equals("ValueElementIdAPI", StringComparison.OrdinalIgnoreCase) == true)
                {
                    type = new ValueElementIdReferenceAPI().GetType();
                }

                objectAPI = new ObjectAPI();
                objectAPI.developerName = GetCleanObjectName(type.Name);
                objectAPI.externalId = externalId;
                objectAPI.properties = new List<PropertyAPI>();

                foreach (PropertyInfo propertyInfo in type.GetRuntimeProperties())
                {
                    PropertyAPI propertyAPI = Convert(source, propertyInfo, valueElementIdReferences);
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
            if (typeof(Dictionary<String, String>).GetTypeInfo().IsAssignableFrom(propertyInfo.PropertyType.GetTypeInfo()))
            {
                return GetTypeElementPropertyAPIFromDictionary(typeElementRequestAPIs, propertyInfo);
            }
            // string inherits from IEnumerable so add a check for "not string"
            else if (typeof(IEnumerable).GetTypeInfo().IsAssignableFrom(propertyInfo.PropertyType.GetTypeInfo()) &&
                     propertyInfo.PropertyType != typeof(string))
            {
                return GetTypeElementPropertyAPIFromCollection(typeElementRequestAPIs, propertyInfo);
            }
            else
            {
                return GetTypeElementPropertyAPIFromType(typeElementRequestAPIs, propertyInfo);
            }
        }

        public static PropertyAPI Convert(object source, PropertyInfo propertyInfo, List<ValueElementIdReferenceAPI> valueElementIdReferences)
        {
            if (typeof(IDictionary).GetTypeInfo().IsAssignableFrom(propertyInfo.PropertyType.GetTypeInfo()))
            {
                return GetPropertyAPIFromDictionary(source, propertyInfo, valueElementIdReferences);
            }
            // string inherits from IEnumerable so add a check for "not string"
            else if (typeof(IEnumerable).GetTypeInfo().IsAssignableFrom(propertyInfo.PropertyType.GetTypeInfo()) &&
                        propertyInfo.PropertyType != typeof(string))
            {
                return GetPropertyAPIFromCollection(source, propertyInfo, valueElementIdReferences);
            }
            else
            {
                return GetPropertyAPIFromType(source, propertyInfo, valueElementIdReferences);
            }
        }

        private static PropertyAPI GetPropertyAPIFromCollection(object source, PropertyInfo propertyInfo, List<ValueElementIdReferenceAPI> valueElementIdReferences)
        {
            IEnumerable values = (IEnumerable)propertyInfo.GetValue(source, null);
            return GetPropertyAPIValueFromCollection(values, propertyInfo, valueElementIdReferences);
        }

        private static TypeElementPropertyAPI GetTypeElementPropertyAPIFromCollection(Dictionary<String, TypeElementRequestAPI> typeElementRequestAPIs, PropertyInfo propertyInfo)
        {
            TypeElementPropertyAPI typeElementPropertyAPI = null;
            Type type = propertyInfo.PropertyType;

            // Check to make sure it is a full on list
            if (type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>))
            {
                Type itemType = type.GetTypeInfo().GenericTypeArguments.ElementAt(0);

                typeElementPropertyAPI = new TypeElementPropertyAPI();
                typeElementPropertyAPI.contentType = ManyWhoConstants.CONTENT_TYPE_LIST;
                typeElementPropertyAPI.developerName = GetCleanPropertyName(propertyInfo.Name);

                // This method returns the name of the root type - which we need here
                typeElementPropertyAPI.typeElementDeveloperName = Convert(itemType, typeElementRequestAPIs);
            }

            return typeElementPropertyAPI;
        }

        private static PropertyAPI GetPropertyAPIValueFromCollection(IEnumerable values, PropertyInfo propertyInfo, List<ValueElementIdReferenceAPI> valueElementIdReferences)
        {
            List<ObjectAPI> objectAPIs = null;
            Type type = propertyInfo.PropertyType;

            // Check to make sure it is a full on list and get the type from the entries
            if (type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>))
            {
                type = type.GetTypeInfo().GenericTypeArguments.ElementAt(0);
            }

            if (values != null)
            {
                objectAPIs = new List<ObjectAPI>();

                foreach (Object objectEntry in values)
                {
                    if (objectEntry is ElementAPI)
                    {
                        // Assign the identifier property from the object
                        objectAPIs.Add(Convert(type, ((ElementAPI)objectEntry).id, objectEntry, valueElementIdReferences));
                    }
                    else
                    {
                        // Assign a random external identifier
                        objectAPIs.Add(Convert(type, Guid.NewGuid().ToString(), objectEntry, valueElementIdReferences));
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

        private static PropertyAPI GetPropertyAPIFromDictionary(object source, PropertyInfo propertyInfo, List<ValueElementIdReferenceAPI> valueElementIdReferences)
        {
            PropertyAPI propertyAPI = null;
            IDictionary value = (IDictionary)propertyInfo.GetValue(source, null);

            if (value != null && propertyInfo.Name.Equals("attributes", StringComparison.OrdinalIgnoreCase))
            {
                var values = value as IDictionary<string, string>;
                if (values.Count > 0)
                {
                    // Add a new list of "Object: String" type objects
                    propertyAPI = new PropertyAPI();
                    propertyAPI.developerName = "Attributes";

                    // For each keypair, create a new "Object: String" object
                    propertyAPI.objectData = new List<ObjectAPI>();

                    foreach (var attribute in values)
                    {
                        propertyAPI.objectData.Add(new ObjectAPI()
                        {
                            developerName = "KeyPair",
                            externalId = Guid.NewGuid().ToString(),
                            properties = new List<PropertyAPI>()
                            {
                                new PropertyAPI() { developerName = "Key", contentValue = attribute.Key },
                                new PropertyAPI() { developerName = "Value", contentValue = attribute.Value }
                            }
                        });
                    }
                }
            }

            return propertyAPI;
        }

        private static PropertyAPI GetPropertyAPIFromComplexType(String externalId, object source, PropertyInfo propertyInfo, List<ValueElementIdReferenceAPI> valueElementIdReferences)
        {
            object propertyValue = propertyInfo.GetValue(source, null);
            List<ObjectAPI> objectData = new List<ObjectAPI>();

            if (propertyValue != null)
            {
                objectData.Add(Convert(source.GetType(), externalId, propertyValue, valueElementIdReferences));
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
            else if (propertyInfo.PropertyType.GetTypeInfo().IsEnum)
            {
                typeElementPropertyAPI.contentType = ManyWhoConstants.CONTENT_TYPE_STRING;
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

        private static PropertyAPI GetPropertyAPIFromType(object source, PropertyInfo propertyInfo, List<ValueElementIdReferenceAPI> valueElementIdReferences)
        {
            List<ObjectAPI> objectData = null;
            string value = null;
            object propertyValue = null;

            // Check to see if the source is a value element identifier, if so we map that over to the full reference
            if (source is ValueElementIdAPI)
            {
                source = FindValueElementIdReferenceForValueElementId((ValueElementIdAPI)source, valueElementIdReferences);
            }

            if (source != null)
            {
                propertyValue = propertyInfo.GetValue(source, null);
            }

            // All of the ValueElementIds are translated to ValueElementIdReferences, so we need to do a little switch here
            if (propertyInfo.PropertyType.Name.Equals("ValueElementIdAPI", StringComparison.OrdinalIgnoreCase) == true)
            {
                // We switch the source to the matching ValueElementIdReference rather than the actual ValueElementId
                source = FindValueElementIdReferenceForValueElementId((ValueElementIdAPI)propertyValue, valueElementIdReferences);
            }

            if (propertyValue != null)
            {
                if (propertyValue is DateTime)
                {
                    value = ((DateTime)propertyValue).ToUniversalTime().ToString();
                }
                else if (propertyValue is Int32 ||
                         propertyValue is Boolean ||
                         propertyValue is String ||
                         propertyValue is Guid)
                {
                    value = propertyValue.ToString();
                }
                else
                {
                    objectData = new List<ObjectAPI>();
                    objectData.Add(Convert(propertyInfo.PropertyType, Guid.NewGuid().ToString(), propertyValue, valueElementIdReferences));
                }
            }

            return new PropertyAPI()
            {
                developerName = GetCleanPropertyName(propertyInfo.Name),
                contentValue = value,
                objectData = objectData,
                typeElementPropertyId = null
            };
        }

        public static String GetTypeName<T>()
        {
            return GetCleanObjectName(typeof(T).Name);
        }

        private static ValueElementIdReferenceAPI FindValueElementIdReferenceForValueElementId(ValueElementIdAPI valueElementId, List<ValueElementIdReferenceAPI> valueElementIdReferences)
        {
            ValueElementIdReferenceAPI valueElementIdReference = null;

            if (valueElementId != null)
            {
                if (valueElementIdReferences != null &&
                    valueElementIdReferences.Count > 0)
                {
                    foreach (ValueElementIdReferenceAPI valueElementIdReferenceEntry in valueElementIdReferences)
                    {
                        // For the value element reference to be a match, both the identifier and the type element property identifier must match
                        if (valueElementIdReferenceEntry.id.Equals(valueElementId.id, StringComparison.OrdinalIgnoreCase) == true &&
                            ((string.IsNullOrWhiteSpace(valueElementId.typeElementPropertyId) == true &&
                             string.IsNullOrWhiteSpace(valueElementIdReferenceEntry.typeElementPropertyId) == true) ||
                             (string.IsNullOrWhiteSpace(valueElementId.typeElementPropertyId) == false &&
                              string.IsNullOrWhiteSpace(valueElementIdReferenceEntry.typeElementPropertyId) == false &&
                              valueElementId.typeElementPropertyId.Equals(valueElementIdReferenceEntry.typeElementPropertyId, StringComparison.OrdinalIgnoreCase) == true)))
                        {
                            valueElementIdReference = valueElementIdReferenceEntry;
                            break;
                        }
                    }
                }

                if (valueElementIdReference == null)
                {
                    // TODO: Warn the author that a reference has gone missing via a notification
                }
            }

            return valueElementIdReference;
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
            if (name.EndsWith("API"))
            {
                return name.Remove(name.LastIndexOf("API", StringComparison.Ordinal));
            }

            return name;
        }
    }
}
