using shoniz.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoniz.shop.CustomerContext.Domain.Customers.Exceptions
{
    class NationalCodeRequiredException : DomainException
    {
        public override string Message => Resources.ExceptionResource.NationalCodeRequiredException;
    }
}
