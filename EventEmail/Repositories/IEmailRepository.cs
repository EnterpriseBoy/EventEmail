using EventEmail.Models;
using System.Threading.Tasks;

namespace EventEmail.Repositories
{
    public interface IEmailRepository
    {
        Task SendEmailAsync(Email email);
    }
}
