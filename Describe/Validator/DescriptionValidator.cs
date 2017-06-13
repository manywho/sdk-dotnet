using ManyWho.Flow.SDK.Errors;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManyWho.Flow.SDK.Describe.Validator
{
    class DescriptionValidator
    {
        public static void validate(DescribeServiceResponseAPI describeService)
        {
            String errorDescription = "";

            foreach (DescribeValueAPI configurationValue in describeService.configurationValues)
            {
                if (!(configurationValue.contentType.Equals(ManyWhoConstants.CONTENT_TYPE_DATETIME) ||
                    configurationValue.contentType.Equals(ManyWhoConstants.CONTENT_TYPE_OBJECT) ||
                    configurationValue.contentType.Equals(ManyWhoConstants.CONTENT_TYPE_NUMBER) ||
                    configurationValue.contentType.Equals(ManyWhoConstants.CONTENT_TYPE_PASSWORD) ||
                    configurationValue.contentType.Equals(ManyWhoConstants.CONTENT_TYPE_STRING) ||
                    configurationValue.contentType.Equals(ManyWhoConstants.CONTENT_TYPE_LIST) ||
                    configurationValue.contentType.Equals(ManyWhoConstants.CONTENT_TYPE_BOOLEAN) ||
                    configurationValue.contentType.Equals(ManyWhoConstants.CONTENT_TYPE_CONTENT) ||
                    configurationValue.contentType.Equals(ManyWhoConstants.CONTENT_TYPE_ENCRYPTED)))
                {
                    errorDescription += String.Format(" ContentType \"{0}\" not supported.", configurationValue.contentType);
                }
                else if (configurationValue.contentType.Equals(ManyWhoConstants.CONTENT_TYPE_OBJECT) || configurationValue.contentType.Equals(ManyWhoConstants.CONTENT_TYPE_LIST))
                {
                    var customType = describeService.install.typeElements.Find(type => type.developerName.Equals(configurationValue.typeElementDeveloperName));
                    if (customType == null)
                    {
                        errorDescription += String.Format(" ContentType \"{0}\" is not installed.", configurationValue.typeElementDeveloperName);
                    }
                }
            }

            if (String.IsNullOrEmpty(errorDescription) == false)
            {
                throw new EngineException(String.Format("Unexpected error:{0}", errorDescription));
            }
        }
    }
}
