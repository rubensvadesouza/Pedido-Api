using Domain.Command.Pedido;
using infra.Model;
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

        public async void Handle(AtualizaValorCommand command)
        {
            await _repository.Update("ID", command.ID, "Valor", command.Valor);
        }

        public async void Handle(AdicionarPedidoCommand command)
        {
            var model = new PedidoModel()
            {
                ID = command.ID,

                Descricao = command.Descricao,
                CNPJ = command.CNPJ,
                Empresa = command.Empresa,
                Status = command.Status,
                Valor = command.Valor
            };

            await _repository.Insert(model);
        }

        public void Handle(RemovePedidoCommand command)
        {
            _repository.DeleteByField("ID", command.ID);
        }
    }
}