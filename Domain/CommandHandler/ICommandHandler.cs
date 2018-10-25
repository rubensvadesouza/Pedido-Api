using Domain.Command;

namespace Domain.CommandHandler
{
    public interface ICommandHander<TCommand>
        where TCommand : ICommand
    {
         void Handle(TCommand command);
    }
}