using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Configuration;

namespace EmailSenderTest
{
    internal class SmtpHelper
    {
        public static bool SendMessage(string subject, string to, string body, bool isHtml = false)
        {
            if (subject == null)
                throw new ArgumentNullException(nameof(subject));
            if (to == null)
                throw new ArgumentNullException(nameof(to));
            if (body == null)
                throw new ArgumentNullException(nameof(body));

            var toCollection = new MailAddressCollection();
            toCollection.Add(to);
            return SendMessage(subject, toCollection, body, isHtml);
        }

        public static bool SendMessage(string from, string subject, string to, string body, bool isHtml = false)
        {
            if (to == null)
                throw new ArgumentNullException(nameof(to));

            var toCollection = new MailAddressCollection();
            toCollection.Add(to);
            return SendMessage(from, subject, toCollection, body, isHtml);
        }

        public static bool SendMessage(string subject, MailAddressCollection toCollection, string body, bool isHtml = false)
        {
            return SendMessage(from: ConfigurationManager.AppSettings["MailSender"], subject, toCollection, body, isHtml);
        }

        public static bool SendMessage(string from, string subject, MailAddressCollection toCollection, string body, bool isHtml = false)
        {
            if (from == null)
                throw new ArgumentNullException(nameof(from));
            if (subject == null)
                throw new ArgumentNullException(nameof(subject));
            if (toCollection == null)
                throw new ArgumentNullException(nameof(toCollection));
            if (!toCollection.Any())
                throw new ArgumentException("toCollection must not be empty");
            if (body == null)
                throw new ArgumentNullException(nameof(body));

            using (var smtp = new SmtpClient(ConfigurationManager.AppSettings["MailServer"]))
            {
                var message = new MailMessage
                {
                    IsBodyHtml = isHtml,
                    From = new MailAddress(from),
                    Subject = subject,
                    Body = body
                };

                foreach (var addr in toCollection)
                {
                    message.To.Add(addr);
                }

                try
                {
                    smtp.Send(message);
                    return true;
                }
                catch (Exception ex)
                {
                    //Logger.ProgramLogger.Error(ex);
                    return false;
                }
            }
        }
    }
}

