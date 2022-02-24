using shoniz.shop.ReadModel.Queries.Contracts.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoniz.shop.ReadModel.Queries.Contracts
{
    public interface ICustomerQueryFacade
    {
        IList<CustomerDto> GetCustomers(string keyword);
    }
}
