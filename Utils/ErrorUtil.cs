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

namespace ManyWho.Flow.SDK.Utils
{
    public class ErrorUtil
    {
        public const String SETTING_SEND_ALERTS = "ManyWho.SendAlerts";
        public const String SETTING_SEND_ALERT_FROM_EMAIL = "ManyWho.SendAlertFromEmail";
        public const String SETTING_SENDGRID_SERVER_BASE_PATH = "ManyWho.SendGrid.ServerBasePath";
        public const String SETTING_SENDGRID_USERNAME = "ManyWho.SendGrid.Username";
        public const String SETTING_SENDGRID_PASSWORD = "ManyWho.SendGrid.Password";
        public const String SETTING_SENDGRID_SMTP = "ManyWho.SendGrid.SMTP";

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

        public static void SendAlert(IAuthenticatedWho authenticatedWho, String alertType, String alertEmail, String pluginName, String faultDescription)
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
    }
}
