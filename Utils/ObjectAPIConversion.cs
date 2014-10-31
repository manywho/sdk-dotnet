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
using ManyWho.Flow.SDK.Run.Elements.Type;
using ManyWho.Flow.SDK.Draw.Elements;
using ManyWho.Flow.SDK.Attributes;

namespace ManyWho.Flow.SDK
{
    public interface IObjectAPIConversion
    {
        ObjectAPI Convert(object source);
        PropertyAPI Convert(object source, PropertyInfo propertyInfo);
    }

    public class ObjectAPIConversion : IObjectAPIConversion
    {
        private Type propertyAPIConversionAttributeType;
        private Type objectAPIConversionAttributeType;

        public ObjectAPIConversion()
        {
            this.propertyAPIConversionAttributeType = typeof(PropertyAPIAttribute);
            this.objectAPIConversionAttributeType = typeof(ObjectAPIAttribute);
        }

        public ObjectAPI Convert(object source)
        {           
            Type type = source.GetType();
            object[] attributes = type.GetCustomAttributes(this.objectAPIConversionAttributeType, false);
            ObjectAPIAttribute conversionAttribute = null;

            if (attributes.Length > 0)
            {
                conversionAttribute = (ObjectAPIAttribute)attributes[0];
            
                ObjectAPI objectAPI = new ObjectAPI();
                objectAPI.developerName = conversionAttribute.ObjectType;
                objectAPI.externalId = conversionAttribute.ExternalId;
                objectAPI.properties = new List<PropertyAPI>();

                foreach (PropertyInfo propertyInfo in type.GetProperties())
                {
                    PropertyAPI propertyAPI = this.Convert(source, propertyInfo);
                    if (propertyAPI != null)
                    {
                        objectAPI.properties.Add(propertyAPI);
                    }
                }

                return objectAPI;
            }

            return null;
        }

        public PropertyAPI Convert(object source, PropertyInfo propertyInfo)
        {                       
            object[] attributes = propertyInfo.GetCustomAttributes(this.propertyAPIConversionAttributeType, false);
            PropertyAPIAttribute conversionAttribute = null;

            if (source is IObjectAPIConvert)
            {
                IObjectAPIConvert objectAPIConvert = (IObjectAPIConvert)source;
                if (objectAPIConvert.IsCustomPropertyConversionEnabled(propertyInfo))
                {
                    return objectAPIConvert.GetPropertyAPI(propertyInfo, conversionAttribute, this);
                }
            }

            if (attributes.Length > 0)
            {
                conversionAttribute = (PropertyAPIAttribute)attributes[0];
                                        
                if (typeof(IDictionary).IsAssignableFrom(propertyInfo.PropertyType))
                {
                    return this.GetPropertyAPIFromDictionary(source, propertyInfo, conversionAttribute);
                }
                // string inherits from IEnumerable so add a check for "not string"
                else if (typeof(IEnumerable).IsAssignableFrom(propertyInfo.PropertyType) && propertyInfo.PropertyType != typeof(string))
                {
                    return this.GetPropertyAPIFromCollection(source, propertyInfo, conversionAttribute);
                }
                else if (conversionAttribute.IsComplexType)
                {
                    return this.GetPropertyAPIFromComplexType(source, propertyInfo, conversionAttribute);
                }
                else
                {
                    return this.GetPropertyAPIFromType(source, propertyInfo, conversionAttribute);
                }
            }
            
            return null;
        }

        private PropertyAPI GetPropertyAPIFromCollection(object source, PropertyInfo propertyInfo, PropertyAPIAttribute conversionAttribute)
        {
            IEnumerable values = (IEnumerable)propertyInfo.GetValue(source, null);
            return this.GetPropertyAPIFromCollection(source, values, conversionAttribute);
        }

        private PropertyAPI GetPropertyAPIFromCollection(object source, IEnumerable values, PropertyAPIAttribute conversionAttribute)
        {
            return new PropertyAPI()
            {
                developerName = conversionAttribute.DeveloperName,
                objectData = (from ElementAPI entry
                              in values
                              select this.Convert(entry)).ToList<ObjectAPI>(),
                typeElementPropertyId = null
            };
        }

        private PropertyAPI GetPropertyAPIFromDictionary(object source, PropertyInfo propertyInfo, PropertyAPIAttribute conversionAttribute)
        {
            IDictionary value = (IDictionary)propertyInfo.GetValue(source, null);
            return this.GetPropertyAPIFromCollection(source, value.Values, conversionAttribute);            
        }

        private PropertyAPI GetPropertyAPIFromComplexType(object source, PropertyInfo propertyInfo, PropertyAPIAttribute conversionAttribute)
        {
            object propertyValue = propertyInfo.GetValue(source, null);
            List<ObjectAPI> objectData = new List<ObjectAPI>();

            if (propertyValue != null)
            {
                objectData.Add(this.Convert(propertyValue));
            }

            return new PropertyAPI()
            {
                developerName = conversionAttribute.DeveloperName,
                objectData = objectData,
                typeElementPropertyId = null
            };
        }

        private PropertyAPI GetPropertyAPIFromType(object source, PropertyInfo propertyInfo, PropertyAPIAttribute conversionAttribute)
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
                developerName = conversionAttribute.DeveloperName,
                contentValue = value,
                objectData = new List<ObjectAPI>(),
                typeElementPropertyId = null
            };
        }
    }
}
