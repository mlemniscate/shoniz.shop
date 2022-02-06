using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace shoniz.shop.CustomerContext.Domain.Customers
{
    class Customer
    {
        public Customer(string nationalCode, string email, string password, string firstName, string lastName)
        {
            SetNationalCode(nationalCode);
            SetEmail(email);
            SetPassword(password);
            SetName(firstName, lastName);
        }

        

        public string NationalCode { get; private set; }
        public string Email { get; private set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private void SetNationalCode(string nationalCode)
        {
            if (string.IsNullOrWhiteSpace(nationalCode))
            {
                throw new Exceptions.NationalCodeRequiredException();
            }

            if (nationalCode.Length < 10)
            {

            }

            if(nationalCode.All(c=> !char.IsDigit(c)))
            {

            }

            NationalCode = nationalCode;
        }

        private void SetEmail(string email)
        {
            if(string.IsNullOrWhiteSpace(email))
            {

            }
            if (!Regex.IsMatch(email, ""))
            {

            }

            Email = email;
        }

        private void SetName(string firstName, string lastName)
        {
            //validate 
            FirstName = firstName;
            LastName = lastName;
        }

        private void SetPassword(string password)
        {
            //validate
            Password = password;
        }
    }
}
