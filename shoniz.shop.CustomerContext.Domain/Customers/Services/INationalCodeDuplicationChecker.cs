using shoniz.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoniz.shop.CustomerContext.Domain.Customers.Services
{
    public interface INationalCodeDuplicationChecker : IDomainService
    {
        bool IsDuplicated(string nationalCode);
    }
}
