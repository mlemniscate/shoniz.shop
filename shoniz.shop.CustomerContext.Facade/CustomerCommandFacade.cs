using shoniz.Framework.Core.Application;
using shoniz.Framework.Core.DependencyInjection;
using shoniz.Framework.Facade;
using shoniz.shop.CustomerContext.ApplicationService.Contracts.Customers;
using Shoniz.Framework.ApplicationService;

namespace shoniz.shop.CustomerContext.Facade
{
    public class CustomerCommandFacade : BaseCommandFacade
    {
        public CustomerCommandFacade(ICommandBus commandBus) : base(commandBus)
        {
        }

        public void Signup(SignupCommand command)
        {
            CommandBus.Dispatch(command);
        }

        public void AddAddress(AddAddressCommand command)
        {
            CommandBus.Dispatch(command);
        }
    }
}
