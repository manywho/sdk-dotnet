using System;
using System.Collections.Generic;
using System.Linq;
using ManyWho.Flow.SDK.Restrictions;

namespace ManyWho.Flow.SDK.Validation
{
    public class RestrictionValidations
    {
        static readonly HashSet<string> CONTINENT_CODES = new HashSet<string> {"AF", "AN", "AS", "EU", "NA", "OC", "SA"};

        public const string INVALID_COUNTRY_CODE = "{0} property value is not valid. The country code '{1}' is not recognized";
        public const string INVALID_CONTINENT_CODE = "{0} property value is not valid. The continent code '{1}' is not recognized";

        public static void ValidateRestrictions(FlowRestrictionsAPI restrictionsApi)
        {
            if (restrictionsApi == null)
            {
                return;
            }

            if (restrictionsApi.Execution != null)
            {
                ValidateRestriction(restrictionsApi.Execution, "Restrictions.Execution");
            }

            if (restrictionsApi.Access != null)
            {
                ValidateRestriction(restrictionsApi.Access, "Restrictions.Access");
            }
        }

        static void ValidateRestriction(RestrictionAPI restriction, string objectName)
        {
            ValidateCountryCodes(objectName, ".countries", restriction.Countries);
            ValidateContinentCodes(objectName, ".continents", restriction.Continents);
        }
        
        static void ValidateCountryCodes(string objectName, string propertyLocation, string[] countryCodes)
        {
            var invalidCode = countryCodes?.FirstOrDefault(code => code.Length != 2);
            if (invalidCode != null)
            {
                throw new ArgumentException(objectName, string.Format(INVALID_COUNTRY_CODE, objectName + propertyLocation, invalidCode));
            }
        }

        static void ValidateContinentCodes(string objectName, string propertyLocation, string[] continentCodes)
        {
            var invalidContinent = FindInvalidContinentCodes(continentCodes);
            if (invalidContinent != null)
            {
                throw new ArgumentException(objectName, string.Format(INVALID_CONTINENT_CODE, objectName + propertyLocation, invalidContinent));
            }
        }
        
        public static string FindInvalidContinentCodes(string[] continentCodes)
        {
            if (continentCodes == null)
            {
                return null;
            }
            
            foreach (var continentCode in continentCodes)
            {
                if (CONTINENT_CODES.Contains(continentCode) == false)
                {
                    return continentCode;
                }
            }

            return null;
        }
    }
}