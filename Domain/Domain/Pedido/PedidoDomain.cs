using Domain.Command.Pedido;
using Domain.CommandHandler.Pedido;
using Domain.Query.Pedido;
using Domain.ViewModel;
using Infra.Enum;
using System.Collections.Generic;

namespace Domain.Pedido
{
    public class PedidoDomain : IPedidoDomain
    {
        protected IPedidoCommandHandler _handler;
        protected IPedidoQuery _query;

        public PedidoDomain()
        {
            _handler = new PedidoCommandHandler();
            _query = new PedidoQuery();
        }

        public void AdicionarPedido(string descricao, string empresa, string cnpj, decimal valor, PedidoStatus status)
        {
            var command = new AdicionarPedidoCommand(descricao, cnpj, empresa, valor, status);
            _handler.Handle(command);
        }

        public void AtualizarPreco(string id, decimal Valor)
        {
            var command = new AtualizarValorCommand(id, Valor);
            _handler.Handle(command);
        }

        public void AtualizarStatus(string id, PedidoStatus status)
        {
            var command = new AtualizarStatusCommand(id, status);
            _handler.Handle(command);
        }

        public List<PedidoViewModel> Listar()
        {
            return _query.Listar();
        }

        public PedidoViewModel ObterPorId(string id)
        {
            throw new System.NotImplementedException();
        }

        public void RemoverPedido(string id)
        {
            var command = new RemoverPedidoCommand(id);
            _handler.Handle(command);
        }
    }
}