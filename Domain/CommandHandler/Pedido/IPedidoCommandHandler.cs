using Domain.Command.Pedido;

namespace Domain.CommandHandler.Pedido
{
    public interface IPedidoCommandHandler :
        ICommandHander<AtualizarValorCommand>,
        ICommandHander<AdicionarPedidoCommand>,
        ICommandHander<RemoverPedidoCommand>
    {
    }
}