using shoniz.Framework.Core.Application;

namespace shoniz.Framework.Facade
{
    public abstract class BaseCommandFacade
    {
        protected BaseCommandFacade(ICommandBus commandBus)
        { 
            CommandBus = commandBus;
        }

        protected ICommandBus CommandBus { get; }
    }
}
