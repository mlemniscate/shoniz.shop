
using Castle.Windsor;

namespace shoniz.Framework.DependencyInjection
{
    public interface IRegistrar
    {
        void Register(WindsorContainer container);
    }
}
