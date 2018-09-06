using Cbci.BillsPayment.ApplicationCore.Entities.OrderAggregate;
using System.Threading.Tasks;

namespace Cbci.BillsPayment.ApplicationCore.Interfaces
{

    public interface IOrderRepository : IRepository<Order>, IAsyncRepository<Order>
    {
        Order GetByIdWithItems(int id);
        Task<Order> GetByIdWithItemsAsync(int id);
    }
}
