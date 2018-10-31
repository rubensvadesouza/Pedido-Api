using Infra.Enum;

namespace Domain.Command.Pedido
{
    public class AtualizarStatusCommand : ICommand
    {
        public AtualizarStatusCommand(string id, PedidoStatus status)
        {
            ID = id;
            Status = status;
        }

        public string ID { get; }

        public PedidoStatus Status { get; }
    }
}