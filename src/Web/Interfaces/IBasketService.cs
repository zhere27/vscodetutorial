using Cbci.BillsPayment.Web.ViewModels;
using System.Threading.Tasks;

namespace Cbci.BillsPayment.Web.Interfaces
{
    public interface IBasketViewModelService
    {
        Task<BasketViewModel> GetOrCreateBasketForUser(string userName);
    }
}
