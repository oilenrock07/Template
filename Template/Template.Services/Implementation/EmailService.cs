using System.Threading.Tasks;
using Template.Services.Interfaces;

namespace Template.Services.Implementation
{
    public class EmailService : IEmailService
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Task.CompletedTask;
        }
    }
}
