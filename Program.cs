using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;


using Microsoft.Extensions.Configuration;

namespace Mail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var objConfig =IConfiguration;
            string MailMessage = "Mail Message Recived";
            string EmailId = "dinesh.m@praathee.com";
            string Subject = "DSE";
            string UserName = "support@pasdailyupdate.com";
            string Password = "Praathee#204060";

            int SMTPPort = 587;
            //Boolean UseSSL = Convert.ToBoolean(Convert.ToInt32(objConfig.GetSection("EmailSettings:UseSSL").Value));
            string SMTPServer = "smtppro.zoho.in";
            try
            {


                //string strEmailText = "<p>Hi </p><br /><br /><p>Your new reseted password for user name <b>" + objUser.UserProfile.Email + " </b> is mentioned Bellow </p><br /><br /><p><b>" + objUser.Password + "</b></p> <br /><br /> <p>Regards <br /> Pasdailyupdate Team</p>";
                string strMailText = "<!DOCTYPE html>";
                strMailText += "<html>";
                strMailText += "<head>";
                strMailText += "<meta charset=\"utf-8\"><meta name=\"x-apple-disable-message-reformatting\"><meta http-equiv=\"x-ua-compatible\" content=\"ie=edge\"><meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"><meta name=\"format-detection\" content=\"telephone=no, date=no, address=no, email=no\">";
                strMailText += "<title>Promotional Mail</title>";
                //strMailText += "<img src=\"~/images/apple-touch-icon.png\" style=\"height:57px; width:45px\" rel=\"stylesheet\" media=\"screen\" ?>";
                strMailText += "<style>.hover-underline:hover {text-decoration: underline !important;}@media (max-width: 600px) {.sm-inline-block {display: inline-block !important;} .sm-w-full {width: 100% !important;}.sm-px-0 {padding-left: 0 !important;padding-right: 0 !important;} .sm-px-24 {padding-left: 24px !important;padding-right: 24px !important;}.sm-py-32 {padding-top: 32px !important;padding-bottom: 32px !important;}.sm-pb-32 {padding-bottom: 32px !important;}.sm-leading-32 {line-height: 32px !important;}}</style>";
                strMailText += "</head>";
                strMailText += "<body style=\"margin: 0; width: 100%; padding: 0; word-break: break-word; -webkit-font-smoothing: antialiased; background-color: #eceff1;\">";
                strMailText += "<div style=\"font-family: 'Montserrat', sans-serif; mso-line-height-rule: exactly; display: none;\">Search Document mail</div>";
                strMailText += "<div role=\"article\" aria-roledescription=\"email\" aria-label=\"Promotional Mail\" lang=\"en\" style=\"font-family: 'Montserrat', sans-serif; mso-line-height-rule: exactly;\">";
                strMailText += "<table style=\"width: 100%; font-family: Montserrat, -apple-system, 'Segoe UI', sans-serif;\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\">";
                strMailText += "<tbody>";
                strMailText += "<tr>";
                strMailText += "<td align=\"center\" style=\"mso-line-height-rule: exactly; background-color: #eceff1; font-family: Montserrat, -apple-system, 'Segoe UI', sans-serif;\">";
                strMailText += "<table class=\"sm-w-full\" style=\"width: 600px;\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\">";
                strMailText += "<tbody>";
                strMailText += "<tr><td class=\"sm-py-32 sm-px-24\" style=\"mso-line-height-rule: exactly; padding: 48px; text-align: center; font-family: Montserrat, -apple-system, 'Segoe UI', sans-serif;\"><a href=\"https://1.envato.market/vuexy_admin\" style=\"font-family: 'Montserrat', sans-serif; mso-line-height-rule: exactly;\"><img src=\"C:\\Users\\hp\\project\\DigitisationSearchEngine\\wwwroot\\images\\Indian_Navy_Insignia_1.png\" width=\"85\" alt=\"Vuexy Admin\" style=\"max-width: 100%; vertical-align: middle; line-height: 100%; border: 0;\"><h3 class=\"mb-1 fw-bold\">Welcome to NHD ID Centric Digital Data Archival and Retrieval Management System!</h3></a></td></tr>";
                strMailText += "<tr>";
                strMailText += "<td align=\"center\" class=\"sm-px-24\" style=\"font-family: 'Montserrat', sans-serif; mso-line-height-rule: exactly;\">";
                strMailText += "<table style=\"width: 100%;\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\"> ";
                strMailText += "<tbody>";
                strMailText += "<tr>";
                strMailText += "<td class=\"sm-px-24\" style=\"mso-line-height-rule: exactly; border-radius: 4px; background-color: #ffffff; padding: 48px; text-align: left; font-family: Montserrat, -apple-system, 'Segoe UI', sans-serif; font-size: 16px; line-height: 24px; color: #626262;\">";
                strMailText += "<p style=\"font-family: 'Montserrat', sans-serif; mso-line-height-rule: exactly; margin-bottom: 0; font-size: 20px; font-weight: 600;\">Hi...</p>";
                strMailText += "<p style=\"font-family: 'Montserrat', sans-serif; mso-line-height-rule: exactly; margin-top: 0; font-size: 24px; font-weight: 700; color: #ff5850;\">";
                strMailText += UserName;
                strMailText += "</p> ";
                strMailText += MailMessage;
                //strMailText += "<p class=\"sm-leading-32\" style=\"font-family: 'Montserrat', sans-serif; mso-line-height-rule: exactly; margin: 0; margin-bottom: 24px; font-size: 24px; font-weight: 600; color: #263238;\">Popular resources of the week!</p>";
                //strMailText += "<p style=\"font-family: 'Montserrat', sans-serif; mso-line-height-rule: exactly; margin: 0; margin-bottom: 24px;\">We're excited to bring you the latest Based On your same<span style=\"font-weight: 600;\">search are the New Document.</span></p>";
                strMailText += "<table cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\"><tbody><tr><td class=\"sm-px-0\" style=\"font-family: 'Montserrat', sans-serif; mso-line-height-rule: exactly; width: 100%; text-align: left;\"><table style=\"width: 100%;\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\"><tbody><tr><td class=\"sm-px-0 sm-pb-32 sm-w-full sm-inline-block\" style=\"font-family: 'Montserrat', sans-serif; mso-line-height-rule: exactly; width: 50%; padding-right: 12px; vertical-align: top;\" valign=\"top\"><h2 style=\"font-family: 'Montserrat', sans-serif; mso-line-height-rule: exactly; margin: 0; margin-bottom: 6px; font-size: 16px; line-height: 1.375; color: #263238;\">Vuexy - Vuejs, React, HTML &amp; Laravel Admin Template</h2><p style=\"font-family: 'Montserrat', sans-serif; mso-line-height-rule: exactly; margin: 0; font-size: 14px;\">By <span style=\"font-weight: 500;\">PIXINVENT</span> in<span style=\"font-weight: 500;\">Admin Templates</span> | <span class=\"post-date\">07-May-2019</span></p></td></tr></tbody></table></td></tr></tbody></table>";
                strMailText += "<table style=\"width: 100%;\" cellpadding=\"0\" cellspacing=\"0\" role=\"presentation\"><tbody><tr><td style=\"font-family: 'Montserrat', sans-serif; mso-line-height-rule: exactly; padding-top: 32px; padding-bottom: 32px;\"><div style=\"font-family: 'Montserrat', sans-serif; mso-line-height-rule: exactly; height: 1px; background-color: #eceff1; line-height: 1px;\">‌</div></td></tr></tbody></table>";
                strMailText += "<p style=\"font-family: 'Montserrat', sans-serif; mso-line-height-rule: exactly; margin: 0; margin-bottom: 16px;\">Not sure why you received this email? Please<a href=\"mailto:support@example.com\" class=\"hover-underline\" style=\"font-family: 'Montserrat', sans-serif; mso-line-height-rule: exactly; color: #7367f0; text-decoration: none;\">let us know</a></p><p style=\"font-family: 'Montserrat', sans-serif; mso-line-height-rule: exactly; margin: 0; margin-bottom: 16px;\">Thanks, <br>The NHD ID Team</p>";
                strMailText += "</td>";
                strMailText += "</tr>";
                strMailText += "<tr><td style=\"font-family: 'Montserrat', sans-serif; mso-line-height-rule: exactly; height: 20px;\"></td></tr><tr><td style=\"font-family: 'Montserrat', sans-serif; mso-line-height-rule: exactly; height: 16px;\"></td></tr>";
                //strMailText += MailMessage;
                strMailText += "</tbody>";
                strMailText += "</table>";
                strMailText += "</td>";
                strMailText += "</tr>";
                strMailText += "</tbody>";
                strMailText += "</table>";
                strMailText += "</td>";
                strMailText += "</tr>";
                strMailText += "</tbody>";
                strMailText += "</table>";
                strMailText += "</div>";
                strMailText += "</body>";
                strMailText += "</html>";

                AlternateView avHtml = System.Net.Mail.AlternateView.CreateAlternateViewFromString(strMailText, null, MediaTypeNames.Text.Html);

                byte[] bitmapData = Convert.FromBase64String(FixBase64ForImage("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"));
                System.IO.MemoryStream streamBitmap = new System.IO.MemoryStream(bitmapData);

                LinkedResource inline = new LinkedResource(streamBitmap, "image/png");
                inline.ContentId = "logo";
                avHtml.LinkedResources.Add(inline);



                System.Net.Mail.SmtpClient objClient = new(SMTPServer, SMTPPort)
                {
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(UserName, Password),
                    //objClient.Credentials = new NetworkCredential("support@pasdailyupdate.com", "Praathee#204060");

                    DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                    EnableSsl = true,
                    Timeout = 1000000
                };

                MailMessage objMessage = new MailMessage(UserName, EmailId);

                objMessage.AlternateViews.Add(avHtml);
                objMessage.IsBodyHtml = true;
                objMessage.Subject = Subject;

                //System.Net.Mail.MailMessage objmessage = new(UserName, EmailId, Subject, MailMessage)
                //{
                //    IsBodyHtml = true
                //};
                objClient.Send(objMessage);
                Console.WriteLine("Mail sent successfully");
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public static string FixBase64ForImage(string Image)
        {
            System.Text.StringBuilder sbText = new System.Text.StringBuilder(Image, Image.Length);
            sbText.Replace("\r\n", string.Empty); sbText.Replace(" ", string.Empty);
            return sbText.ToString();
        }

    }


    //private static string FixBase64ForImage(string v)
    //    {
    //        throw new NotImplementedException();
    //    }



}