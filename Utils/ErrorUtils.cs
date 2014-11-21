using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
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

        public static Boolean IsDebugging(String mode)
        {
            Boolean isDebugging = false;

            // Check the mode to see if the user is debugging
            if (String.IsNullOrWhiteSpace(mode) == false &&
                (mode.Equals(ManyWhoConstants.MODE_DEBUG, StringComparison.OrdinalIgnoreCase) == true) ||
                (mode.Equals(ManyWhoConstants.MODE_DEBUG_STEPTHROUGH, StringComparison.OrdinalIgnoreCase) == true))
            {
                isDebugging = true;
            }

            return isDebugging;
        }

        public static WebException GetWebException(HttpStatusCode statusCode, String reasonPhrase)
        {
            WebException webException = null;
            //HttpWebResponse httpResponseMessage = null;

            // Create the new http response message with the status code
            //httpResponseMessage = new HttpWebResponse();

            // Reason phrases cannot have carriage returns
            //httpResponseMessage.ReasonPhrase = reasonPhrase.Replace(Environment.NewLine, " ");

            // Add the response message to the exception
            webException = new WebException(reasonPhrase.Replace(Environment.NewLine, " "));

            return webException;
        }

        public static WebException GetWebException(HttpStatusCode statusCode, Exception exception)
        {
            // Aggregate the exception and return as a single reason phrase
            return GetWebException(statusCode, AggregateAndWriteErrorMessage(exception, "", false));
        }

        public static WebException GetPluginWebException(IAuthenticatedWho authenticatedWho, Exception exception, String methodName, String pluginName, String shortDescription)
        {
            String message = null;

            // Create a fault message that's more friendly and doesn't expose core stack trace information
            message = "PLUGIN: " + pluginName + " -- We hit a problem while " + shortDescription + ". The method being called on the plugin is: " + methodName + ". ";
            message = "The error we're getting back is: " + AggregateAndWriteErrorMessage(exception, message, false);

            return GetWebException(GetStatusCode(exception), message);
        }

        public static String GetExceptionMessage(Exception exception)
        {
            return AggregateAndWriteErrorMessage(exception, "", false);
        }

        public static String GetExceptionMessage(Exception exception, Boolean includeStackTrace)
        {
            return AggregateAndWriteErrorMessage(exception, "", includeStackTrace);
        }

        public static void SendAlert(INotifier notifier, IAuthenticatedWho authenticatedWho, String alertType, String alertMessage)
        {
            SendAlert(notifier, authenticatedWho, alertType, alertMessage, null);
        }

        public static void SendAlert(INotifier notifier, IAuthenticatedWho authenticatedWho, String alertType, String alertMessage, Exception exception)
        {
            String message = null;

            // Check to see if the caller has in fact provided a notifier - if not, we don't bother to do anything
            if (notifier != null)
            {
                try
                {
                    // Create the full message
                    message = "";

                    // Create the alert message block
                    message += "Alert Message" + Environment.NewLine;
                    message += "-----" + Environment.NewLine;
                    message += alertMessage + Environment.NewLine + Environment.NewLine;

                    // Only include the authenticated who if we have one
                    if (authenticatedWho != null)
                    {
                        // Create the running user summary block
                        message += "Affected User" + Environment.NewLine;
                        message += "-------------" + Environment.NewLine;

                        // Serialize the user information
                        message += NotificationUtils.SerializeAuthenticatedWhoInfo(NotificationUtils.MEDIA_TYPE_PLAIN, authenticatedWho) + Environment.NewLine;
                    }

                    // Finally, we add the exception details if there is an exception
                    message += AggregateAndWriteErrorMessage(exception, "", true);

                    // Set the notification and send
                    notifier.AddNotificationMessage(NotificationUtils.MEDIA_TYPE_PLAIN, message);
                    notifier.SendNotification();
                }
                catch (Exception)
                {
                    // Hide any faults so we're not piling errors on errors
                }
            }
        }

        private static HttpStatusCode GetStatusCode(Exception exception)
        {
            HttpStatusCode httpStatusCode = HttpStatusCode.InternalServerError;

            if (exception != null)
            {
                if (exception is WebException &&
                    ((WebException)exception).Response != null)
                {
                    httpStatusCode = ((HttpWebResponse)((WebException)exception).Response).StatusCode;
                }
            }

            return httpStatusCode;
        }

        private static String AggregateAndWriteErrorMessage(Exception exception, String message, Boolean includeTrace)
        {
            if (exception != null)
            {
                if (exception is AggregateException)
                {
                    message = AggregateAndWriteAggregateErrorMessage((AggregateException)exception, message, includeTrace);
                }
                else if (exception is WebException)
                {
                    message = AggregateAndWriteHttpResponseErrorMessage((WebException)exception, message);
                }
                else
                {
                    message = AggregateAndWriteExceptionErrorMessage(exception, message, includeTrace);
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
                        else if (innerException is WebException)
                        {
                            message = AggregateAndWriteHttpResponseErrorMessage((WebException)innerException, message);
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

        private static String AggregateAndWriteHttpResponseErrorMessage(WebException exception, String message)
        {
            WebResponse webResponse = null;
            String statusDescription = null;

            if (exception != null)
            {
                if (exception.Response != null)
                {
                    webResponse = exception.Response;

                    if (webResponse is HttpWebResponse)
                    {
                        statusDescription = ((HttpWebResponse)webResponse).StatusDescription;

                        // Grab the message from the 
                        if (statusDescription != null &&
                            statusDescription.Trim().Length > 0)
                        {
                            message += "HttpResponseException:" + Environment.NewLine;
                            message += statusDescription + Environment.NewLine + Environment.NewLine;
                        }
                    }
                }
                else
                {
                    message += exception.Message;
                }
            }

            return message;
        }

        private static String AggregateAndWriteExceptionErrorMessage(Exception exception, String message, Boolean includeTrace)
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
