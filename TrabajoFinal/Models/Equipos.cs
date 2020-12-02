using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;

namespace TrabajoFinal.Models
{ 
    class Equipos
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id{get;set;}
        [BsonElement("nombre")]
        public string Nombre { get; set; }
        [BsonElement("edad") ]
        public int Edad { get; set; }
    }
}
