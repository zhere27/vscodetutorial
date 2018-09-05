using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IChannelService
    {
         Task CreateChannelAsync(string accountCode, string accountName, string status, Address address);
    }
}