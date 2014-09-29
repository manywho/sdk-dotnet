using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManyWho.Flow.SDK.Attributes
{
    public class ObjectAPIAttribute : Attribute
    {
        public ObjectAPIAttribute(string objectType)
            : this(objectType, null)
        {
        }

        public ObjectAPIAttribute(string objectType, string externalId)
        {
            this.ObjectType = objectType;
            this.ExternalId = externalId;
        }

        public string ObjectType { get; private set; }
        public string ExternalId { get; private set; }
    }
}
