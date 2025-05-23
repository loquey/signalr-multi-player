
using Microsoft.AspNetCore.Identity.UI.Services;

namespace SignalRClass.Application.Identity
{
    public class DefaultEmailSender(ILogger<DefaultEmailSender> logger) : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            logger.LogInformation(htmlMessage);
            return Task.CompletedTask;
        }
    }
}
