using MongoDB.Bson;
using System.Collections.Generic;

namespace Infra.Entity
{
    public class RemessaVO
    {
        public ObjectId Id { get; set; }
        public string Nome { get; set; }

        public List<SacadoVO> Sacados { get; set; } = new List<SacadoVO>();
    }
}