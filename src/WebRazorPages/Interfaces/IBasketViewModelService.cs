using Cbci.BillsPayment.RazorPages.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cbci.BillsPayment.RazorPages.Interfaces
{
    public interface IBasketViewModelService
    {
        Task<BasketViewModel> GetOrCreateBasketForUser(string userName);
    }
}
