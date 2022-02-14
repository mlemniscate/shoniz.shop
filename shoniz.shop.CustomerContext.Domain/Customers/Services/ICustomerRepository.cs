using shoniz.Framework.Core.Persistance;
using System;
using System.Linq.Expressions;

namespace shoniz.shop.CustomerContext.Domain.Customers.Services
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        void CreateCustomer(Customer customer);

        Customer GetCustomer(Guid customerId);

        void Update(Customer customer);

        bool Contains(Expression<Func<Customer, bool>> predicate);
    }
}
