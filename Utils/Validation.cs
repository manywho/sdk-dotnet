using System;
using System.Collections;
using ManyWho.Flow.SDK.Run.Elements.Type;
using ManyWho.Flow.SDK.Security;

namespace ManyWho.Flow.SDK.Utils
{
    public class Validation
    {
        private static Validation _instance;

        public static Validation Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Validation();
                }

                return _instance;
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
            IsNotNull(value, name, message);

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

        public Validation IsNotEmpty(ICollection value, string name, string message = "")
        {
            IsNotNull(value, name, message);

            if (value.Count == 0)
            {
                if (string.IsNullOrWhiteSpace(message))
                {
                    message = name + " cannot be empty";
                }

                throw new ArgumentException(name, message);
            }

            return this;
        }

        public Validation IsNotEmpty(Array value, string name, string message = "")
        {
            IsNotNull(value, name, message);

            if (value.Length == 0)
            {
                if (string.IsNullOrWhiteSpace(message))
                {
                    message = name + " cannot be empty";
                }

                throw new ArgumentException(name, message);
            }

            return this;
        }

        public Validation IsTrue(bool value, string name, string message = "")
        {
            if (!value)
            {
                if (string.IsNullOrWhiteSpace(message))
                {
                    message = name + " is false";
                }

                throw new ArgumentException(name, message);
            }

            return this;
        }

        public Validation IsNullOrWhiteSpace(string value, string name, string message = "")
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                if (!string.IsNullOrWhiteSpace(message))
                {
                    message = name + " must be null or whitespace";
                }

                throw new ArgumentException(message, name);
            }

            return this;
        }

        public Validation IsNotNullOrWhiteSpace(string value, string name, string message = "")
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
            return IsNotNull(authenticatedWho, "authenticatedWho");
        }

        public Validation TenantId(Guid tenantId)
        {
            return IsNotEmpty(tenantId, "tenantId");
        }

        public Validation ObjectDataRequest(ObjectDataRequestAPI request)
        {
            return IsNotNull(request, "ObjectDataRequest")
                                .IsNotNull(request.objectDataType, "ObjectDataRequest.ObjectDataType")
                                .IsNotNullOrWhiteSpace(request.objectDataType.developerName, "ObjectDataRequest.ObjectDataType.DeveloperName");
        }

    }
}