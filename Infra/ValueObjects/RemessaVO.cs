using MongoDB.Bson;
using System.Collections.Generic;

namespace Infra.Entity
{
    public class RemessaVO
    {

       public RemessaVO()
        {
            Id = ObjectId.GenerateNewId();
        }

        public ObjectId Id { get; set; }
        public string Nome { get; set; }

        public IList<SacadoVO> Sacados { get; set; } = new List<SacadoVO>();
    }
}