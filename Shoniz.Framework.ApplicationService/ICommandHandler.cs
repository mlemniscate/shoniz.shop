namespace Shoniz.Framework.ApplicationService
{
    public interface ICommandHandler<TCommand> where TCommand : Command
    {
        void Execute(TCommand command);
    }
}
