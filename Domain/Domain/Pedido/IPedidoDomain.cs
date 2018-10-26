using Domain.ViewModel;
using Infra.Enum;
using System.Collections.Generic;

namespace Domain.Pedido
{
    public interface IPedidoDomain
    {
        void AtualizarPreco(string id, decimal Valor);

        void AdicionarPedido(string descricao, string cnpj, string empresa, decimal valor, PedidoStatus status);

        void RemoverPedido(string id);

        List<PedidoViewModel> Listar();

        PedidoViewModel ObterPorId(string id);
    }
}