using Shoniz.Framework.ApplicationService;

namespace shoniz.shop.CustomerContext.ApplicationService.Contracts.Customers
{
    public class SignupCommand : Command
    {
        public string NationalCode { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
    }
}
