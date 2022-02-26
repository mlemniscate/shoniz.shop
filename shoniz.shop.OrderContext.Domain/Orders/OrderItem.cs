﻿using System;

namespace shoniz.shop.OrderContext.Domain.Orders
{
    public class OrderItem
    {
        public Guid ProductId { get; set; }

        public int Quantity { get; set; }  

        public decimal Price { get; set; }
    }
}