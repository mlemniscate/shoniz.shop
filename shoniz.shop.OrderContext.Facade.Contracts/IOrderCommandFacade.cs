using shoniz.shop.OrderContext.Application.Contracts.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoniz.shop.OrderContext.Facade.Contracts
{
    public interface IOrderCommandFacade
    {
        void CreateOrder(CreateOrderCommand command);
    }
}
