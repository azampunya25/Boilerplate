using SIMA.Application.DTOs.Mail;
using System.Threading.Tasks;

namespace SIMA.Application.Interfaces.Shared
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}