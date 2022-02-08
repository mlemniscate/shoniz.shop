namespace shoniz.Framework.Core.DependencyInjection
{
    public interface IDiContainer
    {
        T Resolve<T>();
    }
}
