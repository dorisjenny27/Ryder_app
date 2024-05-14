﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryder.Application.Order.Query.GetAllOrderStatus
{
    public class GetAllOrderStatusResponse
    {
        public string Status { get; set; }
        public decimal Amount { get; set; }

        public Guid OrderId { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
