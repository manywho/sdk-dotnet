using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManyWho.Flow.SDK.Attributes
{
    public class PropertyAPIAttribute : Attribute
    {
        public PropertyAPIAttribute(string developerName)
        {
            this.DeveloperName = developerName;
        }

        public string DeveloperName { get; private set; }
    }
}
