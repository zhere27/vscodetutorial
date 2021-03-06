﻿using Cbci.BillsPayment.ApplicationCore.Entities.OrderAggregate;
using System;
using System.Collections.Generic;
using Cbci.BillsPayment.ApplicationCore.Entities.Base;

namespace Cbci.BillsPayment.Web.ViewModels
{
    public class OrderViewModel
    {
        public long OrderNumber { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }

        public Address ShippingAddress { get; set; } 

        public List<OrderItemViewModel> OrderItems { get; set; } = new List<OrderItemViewModel>();

    }

}
