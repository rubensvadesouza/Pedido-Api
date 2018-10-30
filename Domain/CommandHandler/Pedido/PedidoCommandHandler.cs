using Domain.Command.Pedido;
using Infra.Entity;
using Infra.Repository;
using System;

namespace Domain.CommandHandler.Pedido
{
    public class PedidoCommandHandler : IPedidoCommandHandler

    {
        protected PedidoRepository _repository;

        public PedidoCommandHandler()
        {
            var connString = Environment.GetEnvironmentVariable("MongoConnection");
            var dataBase = Environment.GetEnvironmentVariable("MongoDatabase");

            _repository = new PedidoRepository(connString, dataBase);
        }

        public async void Handle(AtualizarValorCommand command)
        {
            await _repository.Update("ID", command.ID, "Valor", command.Valor);
        }

        public async void Handle(AdicionarPedidoCommand command)
        {
            var model = new PedidoEntity()
            {
                Descricao = command.Descricao,
                CNPJ = command.CNPJ,
                Empresa = command.Empresa,
                Status = command.Status,
                Valor = command.Valor
            };

            await _repository.Insert(model);
        }

        public void Handle(RemoverPedidoCommand command)
        {
            _repository.DeleteByField("ID", command.ID);
        }
    }
}