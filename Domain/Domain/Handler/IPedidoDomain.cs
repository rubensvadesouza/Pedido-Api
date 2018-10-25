using Infra.Enum;

namespace Domain.Handler
{
    public interface IPedidoDomain
    {
        void AtualizarPreco(string id, decimal Valor);

        void AdicionarPedido(string description, decimal valor, PedidoStatus status);
        void RemoverPedido(string id);
    }
}