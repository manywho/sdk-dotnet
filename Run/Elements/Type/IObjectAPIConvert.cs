using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ManyWho.Flow.SDK.Run.Elements.Type
{
    public interface IObjectAPIConvert
    {
        PropertyAPI GetPropertyAPI(PropertyInfo propertyInfo, IObjectAPIConversion conversion);
    }
}
