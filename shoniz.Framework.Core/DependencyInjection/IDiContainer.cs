using System.Collections.Generic;

namespace shoniz.Framework.Core.DependencyInjection
{
    public interface IDiContainer
    {
        T Resolve<T>();

        IEnumerable<T> ResolveAll<T>();
    }
}
