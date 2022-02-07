using shoniz.shop.CustomerContext.ApplicationService.Contracts.Customers;
using shoniz.shop.CustomerContext.Domain.Customers;
using shoniz.shop.CustomerContext.Domain.Customers.Services;
using Shoniz.Framework.ApplicationService;
namespace shoniz.shop.CustomerContext.ApplicationService.Customers
{
    public class AddAddressCommandHandler : ICommandHandler<AddAddressCommand>
    {
        private readonly ICustomerRepository customerRepository;

        public AddAddressCommandHandler(
            ICustomerRepository customerRepository
            )
        {
            this.customerRepository = customerRepository;
        }
        public void Execute(AddAddressCommand command)
        {
            var customer = customerRepository.GetCustomer(command.CustomerId);

            var address = new Address(
                customer.Id,
                command.CityId,
                command.PostalCode,
                command.AddressLine
                );
            address.Coordinate = command.Coordinate;
            address.Telephone = command.Telephone;
            customer.AddAddress(address);

            customerRepository.Update(customer); 
        }
    }
}
