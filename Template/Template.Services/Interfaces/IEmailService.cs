using System.Threading.Tasks;

namespace Template.Services.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
