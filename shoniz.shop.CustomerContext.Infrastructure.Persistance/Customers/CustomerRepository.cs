using shoniz.Framework.Persistance;
using shoniz.shop.CustomerContext.Domain.Customers;
using shoniz.shop.CustomerContext.Domain.Customers.Services;
using System.Data.Entity;
using System;
using System.Linq;
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
            return dbContext.Set<Customer>().Any(predicate);
        }

        public void CreateCustomer(Customer customer)
        {
            dbContext.Set<Customer>().Add(customer);
        }

        public Customer GetCustomer(Guid customerId)
        {
            return dbContext
                .Set<Customer>()
                .Include(c => c.Addresses)
                .Single(c => c.Id == customerId);
        }

        public void Update(Customer customer)
        {
        }
    }
}
