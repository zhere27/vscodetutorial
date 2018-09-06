using System.Threading.Tasks;
using Cbci.BillsPayment.ApplicationCore.Entities;
using Cbci.BillsPayment.ApplicationCore.Entities.OrderAggregate;

namespace Cbci.BillsPayment.ApplicationCore.Interfaces
{
    public interface IChannelService
    {
         Task CreateChannelAsync(string accountCode, string accountName, string status, Address address);
    }
}