namespace Domain.Command.Pedido
{
    public class AtualizaValorCommand : ICommand
    {
        public AtualizaValorCommand(string id, decimal valor)
        {
            ID = id;
            Valor = Valor;
        }

        public string ID { get; }

        public decimal Valor { get; }
    }
}