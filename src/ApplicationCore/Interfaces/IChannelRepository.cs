using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IChannelRepository : IRepository<Channel>, IAsyncRepository<Channel>
    {
        Channel GetByIdWithItems(int id);
        Task<Channel> GetByIdWithItemsAsync(int id);
    }
}