using shoniz.shop.CustomerContext.Domain.Customers.Services;

namespace shoniz.shop.CustomerContext.Domain.Services.Customers
{
    public class NationalCodeDuplicationChecker : INationalCodeDuplicationChecker
    {
        private readonly ICustomerRepository customerRepository;

        public NationalCodeDuplicationChecker(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        public bool IsDuplicated(string nationalCode)
        {
            return customerRepository.Contains(c => c.NationalCode == nationalCode);
        }
    }
}
