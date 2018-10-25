namespace Domain.Command
{
    public class AtualizaValorCommand : ICommand
    {
        public AtualizaValorCommand(string _id, decimal _Valor)
        {
            ID = _id;
            Valor = Valor;
        }

        public string ID { get; }

        public decimal Valor { get; }
    }
}