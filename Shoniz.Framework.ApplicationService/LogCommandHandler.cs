using shoniz.Framework.Core.Application;

namespace Shoniz.Framework.ApplicationService
{
    public class LogCommandHandler<TCommand> : ICommandHandler<TCommand> where TCommand : Command 
    {
        private readonly ICommandHandler<TCommand> commandHandler;

        public LogCommandHandler(ICommandHandler<TCommand> commandHandler)
        {
            this.commandHandler = commandHandler;
        }
        public void Execute(TCommand command)
        {
            commandHandler.Execute(command);

            // log
        }
    }
}
