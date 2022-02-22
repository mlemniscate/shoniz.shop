using shoniz.Framework.Core.Application;
using shoniz.Framework.Core.DependencyInjection;

namespace Shoniz.Framework.ApplicationService
{
    public class CommandBus : ICommandBus
    {
        public void Dispatch<TCommand>(TCommand command) where TCommand : Command
        {
            var commandHandler = ServiceLocator.Current.Resolve<ICommandHandler<TCommand>>();
            var transactionalDecorator = new TransactionalCommandHandler<TCommand>(commandHandler);
            var logDecorator = new LogCommandHandler<TCommand>(transactionalDecorator);
            var exceptionControllingDecorator = new ExceptionControlingCommandHandler<TCommand>(logDecorator);    
            exceptionControllingDecorator.Execute(command);
        }
    }
}
