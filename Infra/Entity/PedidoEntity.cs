using Infra.Enum;
using MongoDB.Bson;

namespace Infra.Entity
{
    public class PedidoEntity
    {
        public string _id { get; set; }

        public string CNPJ { get; set; }

        public string Empresa { get; set; }

        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public PedidoStatus Status { get; set; }
    }
}