using System.Collections.Generic;
using Ardalis.GuardClauses;
using Cbci.BillsPayment.ApplicationCore.Entities.OrderAggregate;

namespace Cbci.BillsPayment.ApplicationCore.Entities.Channels
{
    public class Branch : BaseEntity
    {
        public Branch()
        {

        }
        public Branch(Address address)
        {
            Guard.Against.Null(address, nameof(address));

            Address = address;
        }

        public string BranchCode { get; set; }

        public string BranchName { get; set; }

        public string Email { get; set; }

        public long ChannelId { get; set; }
        public Address Address { get; private set; }
        public virtual Channel Channel { get; set; }

        public virtual ICollection<Tpa> Tpa { get; set; }
    }
}