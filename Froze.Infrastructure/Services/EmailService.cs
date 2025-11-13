using Microsoft.Extensions.Logging;
using Froze.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froze.Infrastructure.Services
{
    public class EmailService : IEmailService
    {
        private readonly ILogger<EmailService> _logger;

        public EmailService(ILogger<EmailService> logger)
        {
            _logger = logger;
        }

        public Task SendEmailAsync(string to, string subject, string body)
        {
            // Placeholder implementation - integrate with actual email service
            _logger.LogInformation("Email sent to {To} with subject {Subject}", to, subject);
            return Task.CompletedTask;
        }
    }
}
