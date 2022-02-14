using shoniz.Framework.Domain;

namespace shoniz.Framework.Core.Persistance
{
    public interface IRepository<TAggregateRoot> where TAggregateRoot : IAggregateRoot<TAggregateRoot>
    {

    }
}
