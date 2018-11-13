using Domain.ViewModel;
using Infra.Repository;
using System.Collections.Generic;

namespace Domain.Query.Cedente
{
    public class CedenteQuery : ICedenteQuery
    {
        public CedenteRepository _repo;

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
    }
}