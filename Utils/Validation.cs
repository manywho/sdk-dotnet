using System;
using ManyWho.Flow.SDK.Security;
using ManyWho.Flow.SDK.Run.Elements.Type;

namespace ManyWho.Flow.SDK.Utils
{
    public class Validation
    {
        private static Validation _instance;

        public static Validation Instance
        {
            get
            {
                if (Validation._instance == null)
                {
                    Validation._instance = new Validation();
                }

                return Validation._instance;
            }
        }

        public Validation IsNotNull(object value, string name, string message = "")
        {
            if (value == null)
            {
                if (string.IsNullOrWhiteSpace(message))
                {
                    message = name + " cannot be null";
                }

                throw new ArgumentNullException(name, message);
            }

            return this;
        }

        public Validation IsNotEmpty(Guid value, string name, string message = "")
        {
            this.IsNotNull(value, name, message);

            if (value == Guid.Empty)
            {
                if (string.IsNullOrWhiteSpace(message))
                {
                    message = name + " cannot be empty";
                }

                throw new ArgumentNullException(name, message);
            }
            
            return this;
        }

        public Validation IsNullOrWhiteSpace(string value, string name, string message = "")
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                if (string.IsNullOrWhiteSpace(message))
                {
                    message = name + " cannot be null or whitespace";
                }

                throw new ArgumentNullException(name, message);
            }

            return this;
        }

        public Validation AuthenticatedWho(IAuthenticatedWho authenticatedWho)
        {
            return this.IsNotNull(authenticatedWho, "authenticatedWho");
        }

        public Validation TenantId(Guid tenantId)
        {
            return this.IsNotNull(tenantId, "tenantId")
                                        .IsNotEmpty(tenantId, "tenantId");   
        }

        public Validation ObjectDataRequest(ObjectDataRequestAPI request)
        {
            return this.IsNotNull(request, "ObjectDataRequest")
                                .IsNotNull(request.objectDataType, "ObjectDataRequest.ObjectDataType")
                                .IsNullOrWhiteSpace(request.objectDataType.developerName, "ObjectDataRequest.ObjectDataType.DeveloperName");            
        }

    }
}
