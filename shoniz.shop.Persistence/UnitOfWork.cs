using shoniz.Framework.Persistance;

namespace shoniz.shop.Persistence
{
    public class UnitOfWork : IUnitOfWork 
    {
        private readonly IDbContext context;

        public UnitOfWork(IDbContext context)
        {
            this.context = context;
        }

        public void Commit()
        {
            context.SaveChanges();
        }

        public void RollBack()
        {
            context.Dispose(); // TODO: you can do better design 
        }
    }
}
