namespace shoniz.Framework.Persistance
{
    public interface IUnitOfWork
    {
        void Commit();
        void RollBack();
    }
}
