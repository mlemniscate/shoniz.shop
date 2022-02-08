using shoniz.Framework.Core.Application;
using shoniz.Framework.Core.DependencyInjection;

namespace Shoniz.Framework.ApplicationService
{
    public class CommandBus : ICommandBus
    {
        public void Dispatch<TCommand>(TCommand command) where TCommand : Command
        {
            var commandHandler = ServiceLocator.Current.Resolve<ICommandHandler<TCommand>>();
            commandHandler.Execute(command);
        }
    }


}
