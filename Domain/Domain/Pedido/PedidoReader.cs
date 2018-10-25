using Domain.ViewModel;
using Infra.Repository;
using System;
using System.Collections.Generic;

namespace Domain.Read.Pedido
{
    public class PedidoReader : IPedidoReader
    {
        public PedidoRepository pedidoRepository;

        public PedidoReader()
        {
            var connString = Environment.GetEnvironmentVariable("MongoConnection");
            var dataBase = Environment.GetEnvironmentVariable("MongoDatabase");

            pedidoRepository = new PedidoRepository(connString, dataBase);
        }

        public List<PedidoViewModel> GetAll()
        {
            var pedidoModels = pedidoRepository.GetAll().Result;
            var viewModels = new List<PedidoViewModel>();

            foreach (var pedido in pedidoModels)
            {
                viewModels.Add(pedido);
            }

            return viewModels;
        }

        public PedidoViewModel GetById(string id)
        {
            return pedidoRepository.GetByField("id", id).Result;
        }
    }
}