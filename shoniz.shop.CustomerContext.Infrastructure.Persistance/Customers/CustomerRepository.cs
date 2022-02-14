using shoniz.Framework.Persistance;
using shoniz.shop.CustomerContext.Domain.Customers;
using shoniz.shop.CustomerContext.Domain.Customers.Services;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace shoniz.shop.CustomerContext.Infrastructure.Persistance.Customers
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(IDbContext context) : base(context)
        {
        }
        public bool Contains(Expression<Func<Customer, bool>> predicate)
        {
            return Set.Any(predicate);
        }

        public void CreateCustomer(Customer customer)
        {
            Set.Add(customer);
        }

        public Customer GetCustomer(Guid customerId)
        {
            return GetById(customerId);
        }

        public void Update(Customer customer)
        {
        }
    }
}
