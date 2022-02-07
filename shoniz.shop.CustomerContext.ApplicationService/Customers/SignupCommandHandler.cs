using shoniz.Framework.Core;
using shoniz.shop.CustomerContext.ApplicationService.Contracts.Customers;
using shoniz.shop.CustomerContext.Domain.Customers;
using shoniz.shop.CustomerContext.Domain.Customers.Services;
using Shoniz.Framework.ApplicationService;
namespace shoniz.shop.CustomerContext.ApplicationService.Customers
{
    public class SignupCommandHandler : ICommandHandler<SignupCommand>
    {
        private readonly INationalCodeDuplicationChecker nationalCodeDuplicationChecker;
        private readonly IHashProvider hashProvider;
        private readonly ICustomerRepository customerRepository;

        public SignupCommandHandler(
            INationalCodeDuplicationChecker nationalCodeDuplicationChecker,
            IHashProvider hashProvider,
            ICustomerRepository customerRepository
            )
        {
            this.nationalCodeDuplicationChecker = nationalCodeDuplicationChecker;
            this.hashProvider = hashProvider;
            this.customerRepository = customerRepository;
        }
        public void Execute(SignupCommand command)
        {
            var customer = new Customer(
                nationalCodeDuplicationChecker,
                hashProvider,
                command.NationalCode,
                command.Email,
                command.Password,
                command.FirstName,
                command.LastName
                );

            customerRepository.CreateCustomer(customer);
        }
    }
}
