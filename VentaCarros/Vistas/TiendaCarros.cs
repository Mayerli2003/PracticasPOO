using System;
using Entidades;
using Negocios;

namespace Vistas
{
    class TiendaCarros
    {
        static void Main(string[] args)
        {
            Productos productos = new Productos();
            NegociosProductos negocios = new NegociosProductos();
            Console.WriteLine("Hola bienvenido " +
                "\n¿Qué carro desea comprar?" + 
                "\n1-Chevrolet modelo Aveo." + 
                "\n2-Chevrolet modelo Spark." + 
                "\n3-Isuzu  Trooper." + 
                "\n4-Nissan modelo Pathfinder."+
                "\n5-Nissan modelo Sentra."+
                "\n6-Mitsubishi modelo Lancer."+
                "\n7-Toyota modelo Tacoma."+
                "\n8-KIA modelo Rio."+
                "\n9-KIA modelo Spectra."+
                "\n10-Chevrolet medelo Metro.");
            productos.Id = int.Parse(Console.ReadLine());
            productos = negocios.n_buscarProductoPorId(productos);
            if(productos==null)
            {
                Console.WriteLine("Ese producto no lo tenemos");
            } 
            else
            {
                Console.WriteLine("los datos del carro que va a comprar: "+
                    "\nMarca: "+ productos.Marca +
                    "\nModelo: "+ productos.Modelo +
                    "\nColor: "+ productos.Color +
                    "\nExistencias: "+ productos.Existencias +
                    "\nPrecio: "+ productos.Precio );
            }
        }
    }
}
