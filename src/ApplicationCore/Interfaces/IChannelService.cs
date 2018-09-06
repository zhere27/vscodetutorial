using System.Threading.Tasks;
using Cbci.BillsPayment.ApplicationCore.Entities;
using Cbci.BillsPayment.ApplicationCore.Entities.Base;

namespace Cbci.BillsPayment.ApplicationCore.Interfaces
{
    public interface IChannelService
    {
         Task CreateChannelAsync(string accountCode, string accountName, string status, Address address);
    }
}