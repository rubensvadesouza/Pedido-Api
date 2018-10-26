namespace Domain.Command.Pedido
{
    public class RemovePedidoCommand : ICommand
    {
        public RemovePedidoCommand(string id)
        {
            ID = id;
        }

        public string ID { get; }
    }
}