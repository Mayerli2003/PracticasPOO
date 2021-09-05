using System;
using Entidades;
using Datos;

namespace Negocios
{
    public class NegociosProductos
    {
        DatosProductos datos = new DatosProductos();
        public Productos n_buscarProductoPorId(Productos productos)
        {
            if (productos.Id < 1 || productos.Id > 10)
            {
                return null;
            }
            else
            {
                productos = datos.buscarProductoPorId(productos);
                if (productos == null)
                {
                    return null;
                }
                else
                {
                    return productos;
                }
         
          
            }
    




        }
        public Productos venderProducto(Productos productos,  int cantidad)
        {
            if(cantidad > productos.Existencias)
            {
                Console.WriteLine(" ¡Lo sentimos ! No puede comprar más de "+ productos.Existencias + "carros");
                return null;
            }
            else
            {
                productos = datos.venderProducto(productos, cantidad);
                Console.WriteLine("Se vendieron " + cantidad + " carros de la marca " + productos.Marca + " modelo "+ productos.Modelo +"." +
                   "\nTotal: $" + TotalVenta(productos.Precio, cantidad).ToString("00.00"));

                return productos;
                  
            }
        
    
        }
        public double TotalVenta(double precio, int cantidad)
        {
            double total;
            total = precio * cantidad;

            return total;
        }

    }
}