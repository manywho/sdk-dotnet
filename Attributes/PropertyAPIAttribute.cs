using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManyWho.Flow.SDK.Attributes
{
    public class PropertyAPIAttribute : Attribute
    {
        public PropertyAPIAttribute(string developerName)
            : this(developerName, false)
        {
        }

        public PropertyAPIAttribute(string developerName, bool isComplexType)
        {
            this.DeveloperName = developerName;
            this.IsComplexType = isComplexType;
        }

        public string DeveloperName { get; private set; }
        public bool IsComplexType { get; private set; }
    }
}
