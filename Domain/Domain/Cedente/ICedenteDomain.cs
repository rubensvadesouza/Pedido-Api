using Domain.ViewModel;
using System.Collections.Generic;

namespace Domain.Pedido
{
    public interface ICedenteDomain
    {
        List<CedenteViewModel> Listar();
    }
}