using Infra.Enum;
using MongoDB.Bson;

namespace Infra.Entity
{
    public class SacadoVO
    {
        public SacadoVO()
        {
            Id = ObjectId.GenerateNewId();
        }
        

        public ObjectId Id { get; set; }
        public string Nome { get; set; }
        public string Duplicata { get; set; }
        public string Vencimento { get; set; }
        public decimal Valor { get; set; }
        public string Criterio1 { get; set; }
        public string Criterio2 { get; set; }
        public string Criterio3 { get; set; }
        public string StatusCriterio { get; set; }
        public SacadoStatus Status { get; set; }
    }
}