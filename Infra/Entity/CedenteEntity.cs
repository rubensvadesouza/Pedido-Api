using MongoDB.Bson;
using System.Collections.Generic;

namespace Infra.Entity
{
    public class CedenteEntity: IEntity
    {
        public ObjectId _id { get; set; }
        public string Nome { get; set; }

        public List<RemessaVO> Remessas { get; set; } = new List<RemessaVO>();

    }
}