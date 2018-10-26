namespace Domain.Command.Pedido
{
    public class RemoverPedidoCommand : ICommand
    {
        public RemoverPedidoCommand(string id)
        {
            ID = id;
        }

        public string ID { get; }
    }
}