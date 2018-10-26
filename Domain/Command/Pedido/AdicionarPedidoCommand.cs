using Infra.Enum;
using System;

namespace Domain.Command.Pedido
{
    public class AdicionarPedidoCommand : ICommand
    {
        public AdicionarPedidoCommand(string descricao, string cnpj, string empresa, decimal valor, PedidoStatus status)
        {
            ID = Guid.NewGuid().ToString();
            Descricao = descricao;
            Empresa = empresa;
            CNPJ = cnpj;
            Valor = valor;
            Status = status;
        }

        public string ID { get; set; }

        public string Empresa { get; set; }

        public string CNPJ { get; set; }

        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public PedidoStatus Status { get; set; }
    }
}