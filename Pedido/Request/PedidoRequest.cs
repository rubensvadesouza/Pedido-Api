using Infra.Enum;

namespace Pedido.Request
{
    public class PedidoRequest
    {

        public string CNPJ { get; set; }

        public string Empresa { get; set; }

        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public PedidoStatus Status { get; set; }
    }
}