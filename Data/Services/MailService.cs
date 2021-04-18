using HRMS_Project.Data.Models;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace HRMS_Project.Data.Services
{
    public class MailService : IMailService
    {
        private readonly MailSettings _mailSettings;

        public MailService(IOptions<MailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }

        public async Task<string> SendResetEmailAsync(string email, string resetToken, string url)
        {
            var mail = new MimeMessage();
            mail.Sender = MailboxAddress.Parse(_mailSettings.Mail);
            mail.To.Add(MailboxAddress.Parse(email));
            mail.Subject = "Password reset email";

            var builder = new BodyBuilder();
            builder.HtmlBody = url + HttpUtility.UrlEncode(resetToken);
            mail.Body = builder.ToMessageBody();

            using var smtp = new SmtpClient();
            smtp.Connect(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.StartTls);
            smtp.Authenticate(_mailSettings.Mail, _mailSettings.Password);
            await smtp.SendAsync(mail);

            smtp.Disconnect(true);
            return "sent";
        }
    }
}
