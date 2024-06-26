﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace mei.Models
{
    public class Categoria
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Nome { get; set; }
        public string UsuarioId { get; set; }

    }
}
