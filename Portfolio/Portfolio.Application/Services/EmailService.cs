using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Portfolio.Application.Contracts;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Portfolio.Application.Services
{
    public class EmailService: IEmailService
    {
        public string SendGridSecret { get; set; }
        public string ToEmail { get; set; }

        public EmailService(IConfiguration _config)
        {
            SendGridSecret = _config.GetSection("SendGrid:SecretKey").Value;
            ToEmail = _config.GetSection("SendGrid:ToEmail").Value;
            //_config[]
        }

        public Task SendEmailAsync(string fromEmail, string subject, string htmlMessage)
        {          

            var client = new SendGridClient(SendGridSecret);
            var from = new EmailAddress(fromEmail, "Recruiter");
            var to = new EmailAddress(ToEmail);
            var message = MailHelper.CreateSingleEmail(from, to, subject, "", htmlMessage);
            return client.SendEmailAsync(message);

        }
    }
}
