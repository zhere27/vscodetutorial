using System.Threading.Tasks;
using Cbci.BillsPayment.ApplicationCore.Entities;
using Cbci.BillsPayment.ApplicationCore.Entities.Channels;
using Cbci.BillsPayment.ApplicationCore.Interfaces;

namespace Cbci.BillsPayment.ApplicationCore.Interfaces
{
    public interface IChannelRepository : IRepository<Channel>, IAsyncRepository<Channel>
    {
        Channel GetByIdWithItems(int id);
        Task<Channel> GetByIdWithItemsAsync(int id);
    }
}