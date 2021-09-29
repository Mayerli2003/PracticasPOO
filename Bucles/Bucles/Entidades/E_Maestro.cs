using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucles.Entidades
{
     public class E_Maestro
    {
        private int id;
        private string nombres;
        private string apellidos;
        private int edad;
        private string titulo;

        public E_Maestro() { }
        public E_Maestro(int id, string nombres, string apellidos, int edad, string titulo)
        {
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.edad = edad;
            this.titulo = titulo;
        }

        public int Id { get => id; set => id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public override string ToString()
        {
            return string.Format("Id: {0}, Nombre: {1} {2}, Edad: {3}, Titulo: {4}", id, nombres, apellidos, edad, titulo);
            //Esta parte ayuda con el formato de la posición que tiene cada entidad para poder mostrar los datos de manera ordenada
        }

    }
}
