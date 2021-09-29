using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bucles.Datos;
using Bucles.Entidades;
using Bucles.Negocio;

namespace Bucles.Negocio
{
     public class N_Maestro
    {

        D_Maestro datos = new D_Maestro();


        public List<E_Maestro> N_listaDeMaestros()
        {

            //Con el objeto "datos" se invoca el metodo que devuelve la lista 

            List<E_Maestro> lista = datos.listaDeMaestros();
            return lista;
        }
    }
}
