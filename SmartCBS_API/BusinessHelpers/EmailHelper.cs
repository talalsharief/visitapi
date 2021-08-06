using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace SmartCBSDataAccess.BusinessHelper
{
    public class EmailHelper
    {
        public static bool SendEmail(string Emails, string Message, string Subject)
        {
            try
            {
                if (ValidateEmail(Emails))
                {
                    MailMessage mm = new MailMessage();
                    mm.From = new MailAddress("dsmartsolutionwebsite@gmail.com");

                    mm.To.Add(Emails);
                    mm.IsBodyHtml = true;
                    mm.Body = Message;
                    mm.Subject = Subject;
                    var client = new SmtpClient("smtp.gmail.com", 587)
                    {
                        Credentials = new NetworkCredential("dsmartsolutionwebsite@gmail.com", "imShakeel#1"),
                        EnableSsl = true
                    };

                    client.Send(mm);
                    //client.Send("dsmartsolutionwebsite@gmail.com", toEmail, mm.Subject, mm.Body);
                    return true;

                }
                else
                    return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool ValidateEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}