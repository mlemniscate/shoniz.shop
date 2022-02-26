using shoniz.shop.CustomerContext.ApplicationService.Contracts.Customers;

namespace shoniz.shop.CustomerContext.Facade
{
    public interface ICustomerCommandFacade
    {
        void AddAddress(AddAddressCommand command);

        void Signup(SignupCommand command);

    }
}