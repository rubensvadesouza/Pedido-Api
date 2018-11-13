using Domain.ViewModel;
using FizzWare.NBuilder;
using Infra.Entity;
using Infra.Repository;
using System;
using System.Collections.Generic;

namespace Domain.Query.Cedente
{
    public class CedenteQuery : ICedenteQuery
    {
        public CedenteRepository _repo;

        public CedenteQuery()
        {
            var connString = Environment.GetEnvironmentVariable("MongoConnection");
            var dataBase = Environment.GetEnvironmentVariable("MongoDatabase");

            _repo = new CedenteRepository(connString, dataBase);
        }

        public List<CedenteViewModel> Listar()
        {
            var cedentesEntities = _repo.GetAll().Result;

            var viewModels = new List<CedenteViewModel>();

            foreach (var cedente in cedentesEntities)
            {
                viewModels.Add(cedente);
            }

            return viewModels;
        }

        public void CreateRandomCedentes()
        {
            var cedente = Builder<CedenteEntity>.CreateNew().Build();

            var remessas = Builder<RemessaVO>.CreateListOfSize(new Random().Next(1, 10)).Build();

            foreach (var remessa in remessas)
            {
                remessa.Sacados = Builder<SacadoVO>.CreateListOfSize(new Random().Next(1, 10)).Build();
            }

            cedente.Remessas = remessas;

            _repo.Insert(cedente).GetAwaiter().GetResult();
        }
    }
}