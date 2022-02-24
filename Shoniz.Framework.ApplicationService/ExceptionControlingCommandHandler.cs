using shoniz.Framework.Core.Application;
using System;

namespace Shoniz.Framework.ApplicationService
{
    public class ExceptionControlingCommandHandler<TCommand> : ICommandHandler<TCommand> where TCommand : Command
    {
        private readonly ICommandHandler<TCommand> commandHandler;

        public ExceptionControlingCommandHandler(ICommandHandler<TCommand> commandHandler)
        {
            this.commandHandler = commandHandler;
        }

        public void Execute(TCommand command)
        {
            try
            {
                commandHandler.Execute(command);
            }
            catch (Exception)
            {
                // handle exception
            }
        }
    }
}
