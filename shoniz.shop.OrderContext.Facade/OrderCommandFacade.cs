using shoniz.Framework.Core.Application;
using shoniz.Framework.Facade;
using shoniz.shop.OrderContext.Application.Contracts.Orders;
using shoniz.shop.OrderContext.Facade.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoniz.shop.OrderContext.Facade
{
    public class OrderCommandFacade : BaseCommandFacade, IOrderCommandFacade
    {
        public OrderCommandFacade(ICommandBus commandBus) : base(commandBus)
        {
        }

        public void CreateOrder(CreateOrderCommand command)
        {
            CommandBus.Dispatch(command);
        }
    }
}
