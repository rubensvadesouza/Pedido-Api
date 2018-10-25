namespace Domain.Command
{
    public class RemovePedidoCommand : ICommand
    {
        public RemovePedidoCommand(string _id)
        {
            ID = _id;
        }

        public string ID { get; }
    }
}