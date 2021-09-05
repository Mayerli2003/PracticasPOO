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
            Console.WriteLine("Hola bienvenido/a " +
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
                Console.WriteLine("Los datos del carro que comprará: "+
                    "\nMarca: "+ productos.Marca +
                    "\nModelo: "+ productos.Modelo +
                    "\nColor: "+ productos.Color +
                    "\nExistencias: "+ productos.Existencias +
                    "\nPrecio: "+ productos.Precio );
            }
            
            Console.WriteLine("¿Cuántos carros comprará?");
            int cantidad = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Va a comprar " + cantidad + " carros de la marca " + productos.Marca + " modelo " + productos.Modelo +".");



            productos = negocios.venderProducto(productos, cantidad);

            
            if (productos != null)
            {
                Console.WriteLine("Ahora quedan " + productos.Existencias + " existencias de este producto.");
            }
        }
    }
}
