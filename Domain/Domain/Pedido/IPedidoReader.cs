using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Read.Pedido
{
    public interface IPedidoReader
    {
        List<PedidoViewModel> GetAll();

        PedidoViewModel GetById(string id);
    }
}
