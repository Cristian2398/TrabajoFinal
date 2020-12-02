using MongoDB.Driver;
using System;
using System.Collections.Generic;
using TrabajoFinal.Models;

namespace TrabajoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conexion con mongo
            var client = new MongoClient("mongodb://localhost:27017");
            //Conexion con la BD
            var database = client.GetDatabase("Torneo");
            //Asignar la clase a la coleccion en la Bd
            var EquiposDb = database.GetCollection<Equipos>("persona");


            //Objeto para insertar
            var equipos = new Equipos() { Id= "5fc7d201aa2ffa638621ef96", Nombre = "Hector12", Edad = 22 };
            //Inserrt Objeto

            Console.WriteLine(equipos.Nombre);

            EquiposDb.InsertOne(equipos);


            //List<Equipos> lst = EquiposDb.Find(d => true).ToList();


            //Actualizar por Id
            //EquiposDb.ReplaceOne(d=>d.Id=="5fc7d201aa2ffa638621ef96", equipos);

            //eliminar
            //EquiposDb.DeleteOne(d=>d.Id=="5fc7d201aa2ffa638621ef96");

        }

    }
}
