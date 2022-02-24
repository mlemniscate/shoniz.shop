using shoniz.shop.ReadModel.Context;
using shoniz.shop.ReadModel.Queries.Contracts;
using shoniz.shop.ReadModel.Queries.Contracts.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace shoniz.shop.ReadModel.Queries.Facade.Customers
{
    public class CustomerQueryFacade : ICustomerQueryFacade
    {
        public IList<CustomerDto> GetCustomers(string keyword)
        {
            
            using (var context = new MiladShopEntities())
            {
                return (from customer in context.Customers 
                        where customer.FirstName.Contains(keyword) ||
                        customer.LastName.Contains(keyword) || 
                        customer.Email.Contains(keyword)
                        let hasAddress = customer.Addresses.Any()
                        select new CustomerDto
                        {
                            Id = customer.Id,
                            FirstName = customer.FirstName,
                            LastName = customer.LastName, 
                            Email = customer.Email,
                            HasAddress = hasAddress,
                        }).ToList();
            }
        }
    }
}
