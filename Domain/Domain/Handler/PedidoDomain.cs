using Domain.Command;
using Domain.CommandHandler.Pedidos;
using Infra.Enum;

namespace Domain.Handler
{
    public class PedidoDomain : IPedidoDomain
    {
        protected PedidoCommandHandler _handler;

        public PedidoDomain()
        {
            _handler = new PedidoCommandHandler();
        }

        public void AdicionarPedido(string description, decimal valor, PedidoStatus status)
        {
            var command = new AddPedidoCommand(description, valor, status);
            _handler.Handle(command);
        }

        public void AtualizarPreco(string id, decimal Valor)
        {
            var command = new AtualizaValorCommand(id, Valor);
            _handler.Handle(command);
        }

        public void RemoverPedido(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}