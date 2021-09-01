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
        
    }
    
    
        

        
  

    
    

}