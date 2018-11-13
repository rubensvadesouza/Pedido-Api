using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Entity
{
    public interface IEntity
    {
        ObjectId _id { get; set; }
    }
}
