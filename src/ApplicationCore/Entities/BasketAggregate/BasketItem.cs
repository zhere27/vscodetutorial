﻿using Cbci.BillsPayment.ApplicationCore.Entities.Base;

namespace Cbci.BillsPayment.ApplicationCore.Entities.BasketAggregate
{
    public class BasketItem : BaseEntity
    {
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int CatalogItemId { get; set; }
    }
}
