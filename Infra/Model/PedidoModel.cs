using Infra.Enum;
using MongoDB.Bson;

namespace infra.Model
{
    public class PedidoModel
    {
        public ObjectId _id { get; set; }

        public string CNPJ { get; set; }

        public string Empresa { get; set; }

        public string ID { get; set; }

        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public PedidoStatus Status { get; set; }
    }
}