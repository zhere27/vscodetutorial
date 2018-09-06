using Cbci.BillsPayment.ApplicationCore.Interfaces;
using Ardalis.GuardClauses;
using Cbci.BillsPayment.ApplicationCore.Entities;
using System.Collections.Generic;
using Cbci.BillsPayment.ApplicationCore.Entities.Base;

namespace Cbci.BillsPayment.ApplicationCore.Entities.BuyerAggregate
{
    public class Buyer : BaseEntity, IAggregateRoot
    {
        public string IdentityGuid { get; private set; }

        private List<PaymentMethod> _paymentMethods = new List<PaymentMethod>();

        public IEnumerable<PaymentMethod> PaymentMethods => _paymentMethods.AsReadOnly();

        private Buyer()
        {
            // required by EF
        }

        public Buyer(string identity) : this()
        {
            Guard.Against.NullOrEmpty(identity, nameof(identity));
            IdentityGuid = identity;
        }
    }
}
