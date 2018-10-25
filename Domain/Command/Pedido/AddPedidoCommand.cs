using Infra.Enum;
using System;

namespace Domain.Command
{
    public class AddPedidoCommand : ICommand
    {
        public AddPedidoCommand(string description, decimal valor, PedidoStatus status)
        {
            ID = Guid.NewGuid().ToString();
            Description = description;
            Valor = valor;
            Status = status;
        }

        public string ID { get; set; }

        public string Description { get; set; }

        public decimal Valor { get; set; }

        public PedidoStatus Status { get; set; }
    }
}