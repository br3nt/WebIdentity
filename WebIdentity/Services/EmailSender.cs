using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebIdentity.Services
{
    public class EmailSender : IEmailSender
    {
        public ILogger<EmailSender> Logger { get; set; }

        public EmailSender(ILogger<EmailSender> logger) => Logger = logger;

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            Logger.LogInformation("Sending Email (to: {email}, subject: {subject}, body: {htmlMessage})", email, subject, htmlMessage);
            return Task.CompletedTask;
        }
    }
}
