using shoniz.Framework.Persistance;
using shoniz.shop.CustomerContext.Domain.Customers;
using shoniz.shop.CustomerContext.Domain.Customers.Services;
using System;
using System.Linq.Expressions;

namespace shoniz.shop.CustomerContext.Infrastructure.Persistance.Customers
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DbContextBase dbContext;

        public CustomerRepository(IDbContext dbContext)
        {
            this.dbContext = (DbContextBase)dbContext;
        }
        public bool Contains(Expression<Func<Customer, bool>> predicate)
        {
            dbContext.SaveChanges();
        }

        public void CreateCustomer(Customer customer)
        {
            dbContext.Set<Customer>().Add(customer);
        }

        public Customer GetCustomer(Guid customerId)
        {
        }

        public void Update(Customer customer)
        {
        }
    }
}
