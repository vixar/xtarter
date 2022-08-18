using starter.Application.DTOs.Mail;
using System.Threading.Tasks;

namespace starter.Application.Interfaces.Shared
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}