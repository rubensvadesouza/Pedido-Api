using Domain.Command.Pedido;

namespace Domain.CommandHandler.Pedido
{
    public interface IPedidoCommandHandler :
        ICommandHander<AtualizaValorCommand>,
        ICommandHander<AdicionarPedidoCommand>,
        ICommandHander<RemovePedidoCommand>
    {
    }
}