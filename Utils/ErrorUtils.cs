using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ManyWho.Flow.SDK.Errors;
using Newtonsoft.Json;

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
    public class ErrorUtils
    {
        public const string SETTING_SEND_ALERTS = "ManyWho.SendAlerts";
        public const string SETTING_SEND_ALERT_FROM_EMAIL = "ManyWho.SendAlertFromEmail";
        public const string SETTING_SENDGRID_SERVER_BASE_PATH = "ManyWho.SendGrid.ServerBasePath";
        public const string SETTING_SENDGRID_USERNAME = "ManyWho.SendGrid.Username";
        public const string SETTING_SENDGRID_PASSWORD = "ManyWho.SendGrid.Password";
        public const string SETTING_SENDGRID_SMTP = "ManyWho.SendGrid.SMTP";

        public const string ALERT_TYPE_FAULT = "Fault";
        public const string ALERT_TYPE_WARNING = "Warning";

        private static string AggregateAndWriteErrorMessage(Exception exception, string message, bool includeTrace)
        {
            if (exception != null)
            {
                if (exception is AggregateException)
                {
                    message = AggregateAndWriteAggregateErrorMessage((AggregateException)exception, message, includeTrace);
                }
                else
                {
                    message = AggregateAndWriteExceptionErrorMessage(exception, message, includeTrace);
                }
            }

            return message;
        }

        private static string AggregateAndWriteAggregateErrorMessage(Exception exception, string message, bool includeTrace)
        {
            if (exception is AggregateException)
            {
                AggregateException aex = (AggregateException)exception;

                message += "The exception is an aggregate of the following exceptions:" + Environment.NewLine + Environment.NewLine;

                if (aex.InnerExceptions != null &&
                    aex.InnerExceptions.Any())
                {
                    foreach (Exception innerException in aex.InnerExceptions)
                    {
                        if (innerException is AggregateException)
                        {
                            message = AggregateAndWriteAggregateErrorMessage((AggregateException)innerException, message, includeTrace);
                        }
                        else
                        {
                            message = AggregateAndWriteErrorMessage(innerException, message, includeTrace);
                        }
                    }
                }
            }

            return message;
        }

        private static string AggregateAndWriteExceptionErrorMessage(Exception exception, string message, bool includeTrace)
        {
            if (exception != null)
            {
                message += "Exception:" + Environment.NewLine;
                message += exception.Message + Environment.NewLine + Environment.NewLine;

                if (includeTrace)
                {
                    message += "Stack Trace:" + Environment.NewLine;
                    message += exception.StackTrace + Environment.NewLine + Environment.NewLine;
                }
            }

            return message;
        }

        public static async Task<ApiProblemException> BuildProblemException(HttpResponseMessage response)
        {
            var responseBody = await response.Content.ReadAsStringAsync();

            if (!response.Headers.Contains("X-ManyWho-Service-Problem-Kind") || string.IsNullOrWhiteSpace(responseBody))
            {
                return new ServiceProblemException(new ServiceProblem(response.RequestMessage.RequestUri.AbsoluteUri, response, responseBody));
            }

            var values = response.Headers.GetValues("X-ManyWho-Service-Problem-Kind");
            if (!values.Any())
            {
                return new ServiceProblemException(new ServiceProblem(response.RequestMessage.RequestUri.AbsoluteUri, response, responseBody));
            }

            var problemKind = (ProblemKind)Enum.Parse(typeof(ProblemKind), values.FirstOrDefault());
            switch (problemKind)
            {
                case ProblemKind.api:
                    return new ApiProblemException(JsonConvert.DeserializeObject<ApiProblem>(responseBody));
                case ProblemKind.service:
                    return new ServiceProblemException(JsonConvert.DeserializeObject<ServiceProblem>(responseBody));
            }

            return new ServiceProblemException(new ServiceProblem(response.RequestMessage.RequestUri.AbsoluteUri, response, responseBody));
        }
    }
}
