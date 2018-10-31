using Domain.Command.Pedido;
using Infra.Entity;
using Infra.Repository;
using MongoDB.Bson;
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
                _id = new MongoDB.Bson.ObjectId(),
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

        public void Handle(AtualizarStatusCommand command)
        {
            _repository.Update("_id", ObjectId.Parse(command.ID), "Status", (int)command.Status).GetAwaiter().GetResult();
        }
    }
}