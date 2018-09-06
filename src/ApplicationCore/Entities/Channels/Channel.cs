
using System.Collections.Generic;
using Ardalis.GuardClauses;
using Cbci.BillsPayment.ApplicationCore.Entities;
using Cbci.BillsPayment.ApplicationCore.Interfaces;
using Cbci.BillsPayment.ApplicationCore.Entities.Base;
using Cbci.BillsPayment.ApplicationCore.Services;

namespace Cbci.BillsPayment.ApplicationCore.Entities.Channels
{
    public class Channel : BaseEntity
    {
        private readonly IAppLogger<ChannelService> _logger;

        private readonly List<Branch> _items = new List<Branch>();

        public Channel()
        {
            //required by EF
        }

        public Channel(string accountCode, string accountName, string status, Address address)
        {
            Guard.Against.NullOrEmpty(accountCode,nameof(accountCode));
            Guard.Against.NullOrEmpty(accountName,nameof(accountCode));
            Guard.Against.NullOrEmpty(status,nameof(status));
            Guard.Against.Null(address, nameof(address));

            AccountCode = accountCode;
            AccountName = accountName;
            Address = address;
            Status = status;
        }

        public string AccountCode { get; private set; }

        public string AccountName { get; private set; }

        public string Status { get; private set; }

        public Address Address { get; private set; }

        public ICollection<Branch> Branch { get; set; }

        public IReadOnlyCollection<Branch> Branches => _items.AsReadOnly();

    }
}