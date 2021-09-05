using System;
using Entidades;

namespace Datos
{
    public class DatosProductos
    {
        Productos producto1 = new Productos(1,3000.00,"Chevrolet","Aveo","Azul",20);
        Productos producto2= new Productos(2, 3050.00, "Chevrolet", "Spark", "Rojo", 10);
        Productos producto3 = new Productos(3, 4000.00, "Isuzu", "Trooper", "Negro", 30);
        Productos producto4 = new Productos(4, 5000.50, "Nissan", "Pathfinder", "Verde", 15);
        Productos producto5 = new Productos(5, 3000.00, "Nissan", "Sentra", "Anaranjado", 25);
        Productos producto6 = new Productos(6, 3050.00, "Mitsubishi", "lancer", "Blanco", 40);
        Productos producto7 = new Productos(7, 4700.00, "Toyota", "Tacoma", "Negro", 5);
        Productos producto8 = new Productos(8, 5200.00, "KIA", "Rio", "Amarillo", 55);
        Productos producto9 = new Productos(9, 4100.30, "KIA", "Spectra", "Negro", 31);
        Productos producto10 = new Productos(10, 4500.00, "Chevrolet", "Metro", "Celeste", 13);

        public Productos buscarProductoPorId(Productos productos)
        {
            if(productos.Id == 1)
            {
                productos = producto1;
                return productos;


            }
            else if (productos.Id == 2)
            {
                productos = producto2;
                return productos;
            }
            else if (productos.Id == 3)
            {
                productos = producto3;
                return productos;
            }
            else if (productos.Id == 4)
            {
                productos = producto4;
                return productos;
            }
            else if (productos.Id == 5)
            {
                productos = producto5;
                return productos;
            }
            else if (productos.Id == 6)
            {
                productos = producto6;
                return productos;
            }
            else if (productos.Id == 7)
            {
                productos = producto7;
                return productos;
            }
            else if (productos.Id == 8)
            {
                productos = producto8;
                return productos;
            }
            else if (productos.Id == 9)
            {
                productos = producto9;
                return productos;
            }
            else if (productos.Id == 10)
            {
                productos = producto10;
                return productos;
            }
            else
            {
                return null;
            }
              
            
        



        }
        public Productos venderProducto(Productos productos, int cantidad)
        {
            
            productos.Existencias = (productos.Existencias-cantidad);

            return productos;
        }
    }
}
