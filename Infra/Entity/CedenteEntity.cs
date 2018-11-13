using MongoDB.Bson;
using System.Collections.Generic;

namespace Infra.Entity
{
    public class CedenteEntity: IEntity
    {

        public CedenteEntity()
        {
            _id = ObjectId.GenerateNewId();
        }
        public ObjectId _id { get; set; }
        public string Nome { get; set; }

        public IList<RemessaVO> Remessas { get; set; } = new List<RemessaVO>();

    }
}