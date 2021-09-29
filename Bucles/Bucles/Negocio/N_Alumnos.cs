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
     public class N_Alumnos
    {
        D_Alumnos datos = new D_Alumnos();

        //Este metodo nos trae la lista de alumnos
        //que se encuentra en la capa de datos
        public List<E_Alumnos> N_listaDeAlumnos()
        {

            //Con el objeto "datos" invocamos el metodo
            //que nos devuelve la lista
            List<E_Alumnos> lista = datos.listaDeAlumnos();
            return lista;
        }

        //Este metodo recibe un objeto tipo E_Alumno
        //para enviarlo a la capa de datos y registrarlo
        public void N_agregarAlumno(E_Alumnos alumnoNuevo)
        {
            //Con el objeto "datos" invocamos el metodo
            //que nos permite agregar el alumno a la lista
            datos.AgregarAlumno(alumnoNuevo);
        }

        //Este metodo recibe un objeto tipo E_Alumno
        //para enviarlo a la capa de datos y actualizarlo(editarlo)
        public void N_editarAlumno(E_Alumnos alumnoEditado)
        {
            //Con el objeto "datos" invocamos el metodo
            //que nos permite editar el alumno
            datos.EditarAlumno(alumnoEditado);
        }

        //Este metodo recibe un objeto tipo E_Alumno
        //para enviarlo a la capa de datos y eliminarlo
        public void N_eliminarAlumno(E_Alumnos alumnoEliminado)
        {
            //Con el objeto "datos" invocamos el metodo
            //que nos permite eliminar el alumno
            datos.EliminarAlumno(alumnoEliminado);
        }

    }
}

