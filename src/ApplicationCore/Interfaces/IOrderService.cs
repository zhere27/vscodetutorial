using Cbci.BillsPayment.ApplicationCore.Entities.Base;
using System.Threading.Tasks;

namespace Cbci.BillsPayment.ApplicationCore.Interfaces
{
    public interface IOrderService
    {
        Task CreateOrderAsync(int basketId, Address shippingAddress);
    }
}
