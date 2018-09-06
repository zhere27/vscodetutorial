using System.Threading.Tasks;

namespace Cbci.BillsPayment.ApplicationCore.Interfaces
{

    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
