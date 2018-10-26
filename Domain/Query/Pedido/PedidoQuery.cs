using Domain.ViewModel;
using Infra.Repository;
using System;
using System.Collections.Generic;

namespace Domain.Query.Pedido
{
    public class PedidoQuery : IPedidoQuery
    {
        public PedidoRepository pedidoRepository;

        public PedidoQuery()
        {
            var connString = Environment.GetEnvironmentVariable("MongoConnection");
            var dataBase = Environment.GetEnvironmentVariable("MongoDatabase");

            pedidoRepository = new PedidoRepository(connString, dataBase);
        }

        public List<PedidoViewModel> Listar()
        {
            var pedidoModels = pedidoRepository.GetAll().Result;
            var viewModels = new List<PedidoViewModel>();

            foreach (var pedido in pedidoModels)
            {
                viewModels.Add(pedido);
            }

            return viewModels;
        }

        public PedidoViewModel ObterPorId(string id)
        {
            var ret = pedidoRepository.GetByField("ID", id).Result;
            return ret;
        }
    }
}