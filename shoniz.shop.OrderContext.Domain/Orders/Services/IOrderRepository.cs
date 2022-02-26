﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoniz.shop.OrderContext.Domain.Orders.Services
{
    public interface IOrderRepository
    {
        int GenerateOrderNumber();
        void Create(Order order);
    }
}
