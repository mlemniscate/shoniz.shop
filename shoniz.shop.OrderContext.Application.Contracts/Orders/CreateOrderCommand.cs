using shoniz.Framework.Core.Application;
using shoniz.shop.OrderContext.Domain.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoniz.shop.OrderContext.Application.Contracts.Orders
{
    public class CreateOrderCommand : Command
    {

        public IList<OrderItem> Cart { get; set; }
    }
}
