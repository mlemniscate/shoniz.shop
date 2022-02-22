using shoniz.Framework.Domain;
using System;
using System.Data.Entity;
using System.Linq;

namespace shoniz.Framework.Persistance
{
    public abstract class RepositoryBase<TAggregateRoot> 
        where TAggregateRoot : EntityBase, IAggregateRoot<TAggregateRoot> , new()
    {
        protected readonly DbContextBase context;

        protected RepositoryBase(IDbContext context)
        {
            this.context = context as DbContextBase;
        }

        protected DbSet<TAggregateRoot> Set
        {
            get
            {
                var set = context.Set<TAggregateRoot>().AsQueryable();
                var includeExpressions = new TAggregateRoot().GetAggregateExpressions();
                foreach (var expression in includeExpressions)
                {
                    set = set.Include(expression);
                }
                return (DbSet<TAggregateRoot>)set;
            }
        }

        protected TAggregateRoot GetById(Guid id)
        {
            return Set.Single(e => e.Id == id);
        }
    }
}
