using apiwithonion.Domain.Settings;
using System.Threading.Tasks;

namespace apiwithonion.Service.Contract
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
