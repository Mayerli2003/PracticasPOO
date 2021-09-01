using System;

namespace Entidades
{
    public class Productos
    {
        private int id;
        private double precio;
        private string marca;
        private string modelo;
        private string color;
        private int existencias;

        public Productos() { }
        public Productos(int id, double precio, string marca, string modelo, string color, int existencias)
        {
            this.id = id;
            this.precio = precio;
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.existencias = existencias;
        }

        public int Id { get => id; set => id = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public int Existencias { get => existencias; set => existencias = value; }

        
    }
}
