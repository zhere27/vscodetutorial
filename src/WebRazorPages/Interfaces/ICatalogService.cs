using Microsoft.AspNetCore.Mvc.Rendering;
using Cbci.BillsPayment.RazorPages.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cbci.BillsPayment.RazorPages.Interfaces
{
    public interface ICatalogService
    {
        Task<CatalogIndexViewModel> GetCatalogItems(int pageIndex, int itemsPage, int? brandId, int? typeId);
        Task<IEnumerable<SelectListItem>> GetBrands();
        Task<IEnumerable<SelectListItem>> GetTypes();
    }
}
