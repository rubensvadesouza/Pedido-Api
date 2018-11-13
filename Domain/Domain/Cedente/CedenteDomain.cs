using Domain.Query.Cedente;
using Domain.ViewModel;
using System.Collections.Generic;

namespace Domain.Pedido
{
    public class CedenteDomain : ICedenteDomain
    {
        protected ICedenteQuery _query;

        public CedenteDomain()
        {
            _query = new CedenteQuery();
        }

        public List<CedenteViewModel> Listar()
        {
            return _query.Listar();
        }
    }
}