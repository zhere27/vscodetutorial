using System.Threading.Tasks;
using Cbci.BillsPayment.ApplicationCore.Entities;
using Cbci.BillsPayment.ApplicationCore.Interfaces;
using Ardalis.GuardClauses;
using Cbci.BillsPayment.ApplicationCore.Entities.Channels;
using Cbci.BillsPayment.ApplicationCore.Entities.Base;

namespace Cbci.BillsPayment.ApplicationCore.Services
{
    public class ChannelService : IChannelService
    {
        private readonly IAsyncRepository<Channel> _channelRepository;

        private readonly IAppLogger<ChannelService> _logger;

        public ChannelService(IAsyncRepository<Channel> channelRepository, IAppLogger<ChannelService> logger)
        {
            _channelRepository = channelRepository;
            _logger = logger;
        }
        public async Task CreateChannelAsync(string accountCode, string accountName, string status, Address address)
        {
            var channel = new Channel(accountCode, accountName, status, address);
            _logger.LogInformation($"Channel Account for {accountCode} has been created.");
            await _channelRepository.AddAsync(channel);
        }
    }
}