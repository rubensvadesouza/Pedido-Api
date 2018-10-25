using Domain.Command;
using infra.Model;
using Infra.Repository;
using System;

namespace Domain.CommandHandler.Pedidos
{
    public class PedidoCommandHandler :
        ICommandHander<AtualizaValorCommand>,
        ICommandHander<AddPedidoCommand>,
        ICommandHander<RemovePedidoCommand>
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

        public async void Handle(AddPedidoCommand command)
        {
            var model = new PedidoModel()
            {
                ID = command.ID,
                Description = command.Description,
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