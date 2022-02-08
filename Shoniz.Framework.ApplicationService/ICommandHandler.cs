using shoniz.Framework.Core.Application;

namespace Shoniz.Framework.ApplicationService
{
    public interface ICommandHandler<TCommand> where TCommand : Command
    {
        void Execute(TCommand command);
    }
}
