using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bucles.Entidades;

namespace Bucles.Datos
{
     public class D_Maestro
    {
        //Esta clase ayudará a guardar los datos asumiendo el rol de una base de datos
        //List<E_Maestro> es la lista que guardará todos los datos de los usuarios en base a las entidades E_Maestro
        List<E_Maestro> listaMaestros = new List<E_Maestro>();
        public List<E_Maestro> listaDeMaestros()
        {

            //Si la lista ya tiene datos
            if (listaMaestros.Count != 0)
            {
                //Nos retorna la lista con los datos que tenga
                return listaMaestros;
            }

            //Si la lista no tiene datos
            else
            {
                //Agregar los datos
                listaMaestros.Add(new E_Maestro(1, "William ", "Diaz", 26, "Ingeniería en sistemas")); //Posicion [0], la primera fila  tiene la posición 0
                listaMaestros.Add(new E_Maestro(2, "Teresa", "Monterrosa", 30, "Licenciatura en computación")); //Posicion [1]
                listaMaestros.Add(new E_Maestro(3, "María", "Ventura", 29, "Licenciatura en Mercadeo")); //Posicion [2]
                listaMaestros.Add(new E_Maestro(4, "Ingrid", "Montes", 25, "Licenciatura en administración de empresas")); //Posicion [3]
                listaMaestros.Add(new E_Maestro(5, "Nelson", "Trinidad", 23, "Licenciatura en turismo")); //Posicion [4]

                //Y  retorna la lista con los datos
                return listaMaestros;
            }
        }



     }
}
