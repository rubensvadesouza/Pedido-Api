using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Query.Pedido
{
    public interface IPedidoQuery
    {
        List<PedidoViewModel> Listar();

        PedidoViewModel ObterPorId(string id);
    }
}
