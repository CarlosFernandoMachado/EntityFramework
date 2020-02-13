using System;

namespace Aplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            context DB = new context();
            Objetos obj = new Objetos();

            //Agregar a la base de datos
            obj.Mensaje = "Muchos Adios";
            DB.Tabla.Add(obj);
            DB.SaveChanges();


            Console.WriteLine("Se ha agregado a la BD");

        }
    }
}
