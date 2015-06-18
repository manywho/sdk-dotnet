using System;
using System.Linq;
using ManyWho.Flow.SDK.Translate;

/*!

Copyright 2013 Manywho, Inc.

Licensed under the Manywho License, Version 1.0 (the "License"); you may not use this
file except in compliance with the License.

You may obtain a copy of the License at: http://manywho.com/sharedsource

Unless required by applicable law or agreed to in writing, software distributed under
the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the specific language governing
permissions and limitations under the License.

*/

namespace ManyWho.Flow.SDK.Utils
{
    public class InternationalizationUtils
    {
        public static CultureAPI Deserialize(string token)
        {
            CultureAPI culture = null;
            string[] parameters = null;
            string brandParameter = null;
            string countryParameter = null;
            string languageParameter = null;
            string variantParameter = null;

            // Start by splitting the string so we have a complete key/value pairing
            parameters = token.Split('&');

            // Grab the parameters for each of the properties from the array
            brandParameter = parameters.Single(value => value.StartsWith(ManyWhoConstants.CULTURE_TOKEN_BRAND, StringComparison.OrdinalIgnoreCase));
            countryParameter = parameters.Single(value => value.StartsWith(ManyWhoConstants.CULTURE_TOKEN_COUNTRY, StringComparison.OrdinalIgnoreCase));
            languageParameter = parameters.Single(value => value.StartsWith(ManyWhoConstants.CULTURE_TOKEN_LANGUAGE, StringComparison.OrdinalIgnoreCase));
            variantParameter = parameters.Single(value => value.StartsWith(ManyWhoConstants.CULTURE_TOKEN_VARIANT, StringComparison.OrdinalIgnoreCase));

            Validation.Instance.IsNotNullOrWhiteSpace(brandParameter, "Brand", "Missing parameter: " + ManyWhoConstants.CULTURE_TOKEN_BRAND)
                                .IsNotNullOrWhiteSpace(brandParameter, "Country", "Missing parameter: " + ManyWhoConstants.CULTURE_TOKEN_COUNTRY)
                                .IsNotNullOrWhiteSpace(brandParameter, "Language", "Missing parameter: " + ManyWhoConstants.CULTURE_TOKEN_LANGUAGE)
                                .IsNotNullOrWhiteSpace(brandParameter, "Variant", "Missing parameter: " + ManyWhoConstants.CULTURE_TOKEN_VARIANT);
            
            // Create our new authenticated who object
            culture = new CultureAPI();
            culture.brand = brandParameter.Split(ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER)[1];
            culture.country = countryParameter.Split(ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER)[1];
            culture.language = languageParameter.Split(ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER)[1];
            culture.variant = variantParameter.Split(ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER)[1];

            return culture;
        }

        public static string Serialize(CultureAPI culture)
        {
            string token = "";

            if (culture.brand == null)
            {
                culture.brand = "";
            }

            if (culture.country == null)
            {
                culture.country = "";
            }

            if (culture.language == null)
            {
                culture.language = "";
            }

            if (culture.variant == null)
            {
                culture.variant = "";
            }

            // Construct the token string
            token += ManyWhoConstants.CULTURE_TOKEN_BRAND + ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER + culture.brand + "&";
            token += ManyWhoConstants.CULTURE_TOKEN_COUNTRY + ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER + culture.country + "&";
            token += ManyWhoConstants.CULTURE_TOKEN_LANGUAGE + ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER + culture.language + "&";
            token += ManyWhoConstants.CULTURE_TOKEN_VARIANT + ManyWhoConstants.SERIALIZATION_DELIMITER_DELIMITER + culture.variant + "&";

            // Encode the token ready for http
            return token;
        }
    }
}
