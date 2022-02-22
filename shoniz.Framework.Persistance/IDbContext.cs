using System;

namespace shoniz.Framework.Persistance
{
    public interface IDbContext : IDisposable
    {
        int SaveChanges();
    }
}
