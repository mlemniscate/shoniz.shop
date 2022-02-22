using shoniz.Framework.Core.Application;
using shoniz.Framework.Core.DependencyInjection;
using shoniz.Framework.Persistance;
using System;

namespace Shoniz.Framework.ApplicationService
{
    public class TransactionalCommandHandler<TCommand> : ICommandHandler<TCommand> where TCommand : Command 
    {
        private readonly ICommandHandler<TCommand> commandHandler;

        public TransactionalCommandHandler(ICommandHandler<TCommand> commandHandler)
        {
            this.commandHandler = commandHandler;
        }
        public void Execute(TCommand command)
        {
            var unitOfWork = ServiceLocator.Current.Resolve<IUnitOfWork>();
            try
            {
                commandHandler.Execute(command);
                unitOfWork.Commit();
            }
            catch 
            {
                unitOfWork.RollBack();
                throw;
            }
             
        }
    }
}
