using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using ManyWho.Flow.SDK.Attributes;

namespace ManyWho.Flow.SDK.Run.Elements.Type
{
    public interface IObjectAPIConvert
    {
        PropertyAPI GetPropertyAPI(PropertyInfo propertyInfo, PropertyAPIAttribute attribute, IObjectAPIConversion conversion);
        bool IsCustomPropertyConversionEnabled(PropertyInfo propertyInfo);
    }
}
