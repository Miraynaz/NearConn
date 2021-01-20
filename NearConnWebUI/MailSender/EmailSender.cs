using Microsoft.AspNetCore.Identity.UI.Services;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NearConnWebUI.MailSender
{
    public class EmailSender : IEmailSender
    {
        private const string SendGridKey = "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";
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(SendGridKey, subject, htmlMessage, email);
        }

        private Task Execute(string sendGridKey, string subject, string htmlMessage, string email)
        {
            var client = new SendGridClient(sendGridKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("info@nearconn.com.tr", "NearConn"),
                Subject=subject,
                PlainTextContent=htmlMessage,
                HtmlContent=htmlMessage
            };
            msg.AddTo(new EmailAddress(email));
            return client.SendEmailAsync(msg);
        }

    }
}
