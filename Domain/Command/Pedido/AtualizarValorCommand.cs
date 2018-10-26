namespace Domain.Command.Pedido
{
    public class AtualizarValorCommand : ICommand
    {
        public AtualizarValorCommand(string id, decimal valor)
        {
            ID = id;
            Valor = Valor;
        }

        public string ID { get; }

        public decimal Valor { get; }
    }
}