using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace shoniz.Framework.Domain
{
    public interface IAggregateRoot<TAggregateRoot>
    {
        IEnumerable<Expression<Func<TAggregateRoot, object>>> GetAggregateExpressions();
    }
}
