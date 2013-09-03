using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Net.Http;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using Microsoft.WindowsAzure;
using ManyWho.Flow.SDK.Security;

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
        public const String SETTING_SEND_ALERTS = "ManyWho.SendAlerts";
        public const String SETTING_SEND_ALERT_FROM_EMAIL = "ManyWho.SendAlertFromEmail";
        public const String SETTING_SENDGRID_SERVER_BASE_PATH = "ManyWho.SendGrid.ServerBasePath";
        public const String SETTING_SENDGRID_USERNAME = "ManyWho.SendGrid.Username";
        public const String SETTING_SENDGRID_PASSWORD = "ManyWho.SendGrid.Password";
        public const String SETTING_SENDGRID_SMTP = "ManyWho.SendGrid.SMTP";

        public const String ALERT_TYPE_FAULT = "Fault";
        public const String ALERT_TYPE_WARNING = "Warning";

        public static HttpResponseException GetWebException(HttpStatusCode statusCode, String reasonPhrase)
        {
            HttpResponseException httpResponseException = null;
            HttpResponseMessage httpResponseMessage = null;

            // Create the new http response message with the status code
            httpResponseMessage = new HttpResponseMessage(statusCode);

            // Reason phrases cannot have carriage returns
            httpResponseMessage.ReasonPhrase = reasonPhrase.Replace(Environment.NewLine, " ");

            // Add the response message to the exception
            httpResponseException = new HttpResponseException(httpResponseMessage);

            return httpResponseException;
        }

        public static HttpResponseException GetWebException(HttpStatusCode statusCode, Exception exception)
        {
            // Aggregate the exception and return as a single reason phrase
            return GetWebException(statusCode, AggregateAndWriteErrorMessage(exception, false));
        }

        public static void SendAlert(IAuthenticatedWho authenticatedWho, String alertType, String alertEmail, String pluginName, String faultDescription)
        {
            SendAlert(authenticatedWho, alertType, alertEmail, pluginName, faultDescription, null);
        }

        public static void SendAlert(IAuthenticatedWho authenticatedWho, String alertType, String alertEmail, String pluginName, String faultDescription, Exception exception)
        {
            NetworkCredential networkCredentials = null;
            SmtpClient smtpClient = null;
            MailMessage mailMessage = null;
            String message = null;

            if (alertEmail != null &&
                alertEmail.Trim().Length > 0)
            {
                try
                {
                    if (Boolean.Parse(CloudConfigurationManager.GetSetting(SETTING_SEND_ALERTS)) == true)
                    {
                        mailMessage = new MailMessage();
                        mailMessage.To.Add(new MailAddress(alertEmail, alertEmail));
                        mailMessage.From = new MailAddress(CloudConfigurationManager.GetSetting(SETTING_SEND_ALERT_FROM_EMAIL), CloudConfigurationManager.GetSetting(SETTING_SEND_ALERT_FROM_EMAIL));
                        mailMessage.Subject = pluginName + " - Plugin " + alertType + " Alert";

                        // Create the full message
                        message = "";

                        // Create the fault description block
                        message += "Fault" + Environment.NewLine;
                        message += "-----" + Environment.NewLine;
                        message += faultDescription + Environment.NewLine + Environment.NewLine;

                        // Create the flow summary block
                        message += "Plugin" + Environment.NewLine;
                        message += "------" + Environment.NewLine;
                        message += "Name: " + pluginName + Environment.NewLine + Environment.NewLine;

                        // Create the running user summary block
                        message += "Affected User" + Environment.NewLine;
                        message += "-------------" + Environment.NewLine;

                        if (authenticatedWho != null)
                        {
                            message += "User Id: " + authenticatedWho.UserId + Environment.NewLine;
                            message += "Directory Id: " + authenticatedWho.DirectoryId + Environment.NewLine;
                            message += "Directory Name: " + authenticatedWho.DirectoryName + Environment.NewLine;
                            message += "Email: " + authenticatedWho.Email + Environment.NewLine + Environment.NewLine;
                        }
                        else
                        {
                            message += "Unknown" + Environment.NewLine + Environment.NewLine;
                        }

                        // Finally, we add the exception details if there is an exception
                        message += AggregateAndWriteErrorMessage(exception, true);

                        // Create the message in our mail system
                        mailMessage.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(message, null, MediaTypeNames.Text.Plain));

                        networkCredentials = new NetworkCredential(CloudConfigurationManager.GetSetting(SETTING_SENDGRID_USERNAME), CloudConfigurationManager.GetSetting(SETTING_SENDGRID_PASSWORD));

                        smtpClient = new SmtpClient(CloudConfigurationManager.GetSetting(SETTING_SENDGRID_SMTP), Convert.ToInt32(587));
                        smtpClient.Credentials = networkCredentials;
                        smtpClient.Send(mailMessage);
                    }
                }
                catch (Exception)
                {
                    // Hide any faults so we're not piling errors on errors
                }
            }
        }

        private static String AggregateAndWriteErrorMessage(Exception exception, Boolean includeTrace)
        {
            String message = null;

            if (exception != null)
            {
                message = "";

                if (exception is AggregateException)
                {
                    message = AggregateAndWriteAggregateErrorMessage((AggregateException)exception, message, includeTrace);
                }
                else if (exception is HttpResponseException)
                {
                    message = AggregateAndWriteHttpResponseErrorMessage((HttpResponseException)exception, message);
                }
                else
                {
                    message = AggregateAndWriteErrorMessage(exception, message, includeTrace);
                }
            }

            return message;
        }

        private static String AggregateAndWriteAggregateErrorMessage(Exception exception, String message, Boolean includeTrace)
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
                        else if (innerException is HttpResponseException)
                        {
                            message = AggregateAndWriteHttpResponseErrorMessage((HttpResponseException)exception, message);
                        }
                        else
                        {
                            message = AggregateAndWriteErrorMessage(exception, message, includeTrace);
                        }
                    }
                }
            }

            return message;
        }

        private static String AggregateAndWriteHttpResponseErrorMessage(HttpResponseException exception, String message)
        {
            if (exception != null &&
                exception.Response != null)
            {
                HttpResponseMessage responseException = exception.Response;

                // Grab the message from the 
                if (responseException.ReasonPhrase != null &&
                    responseException.ReasonPhrase.Trim().Length > 0)
                {
                    message += "HttpResponseException:" + Environment.NewLine;
                    message += responseException.ReasonPhrase + Environment.NewLine + Environment.NewLine;
                }
            }

            return message;
        }

        private static String AggregateAndWriteErrorMessage(Exception exception, String message, Boolean includeTrace)
        {
            if (exception != null)
            {
                message += "Exception:" + Environment.NewLine;
                message += exception.Message + Environment.NewLine + Environment.NewLine;

                if (includeTrace == true)
                {
                    message += "Stack Trace:" + Environment.NewLine;
                    message += exception.StackTrace + Environment.NewLine + Environment.NewLine;
                }
            }

            return message;
        }
    }
}
