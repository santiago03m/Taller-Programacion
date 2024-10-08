using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaVideojuegos
{
    public class Videojuego
    {
        private int codigo;
        private string nombre;
        private string autor;
        private bool estado;

        public Videojuego(int codigo, string nombre, string autor, bool estado)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.autor = autor;
            this.estado = estado;
        }

        public int Codigo{ get => codigo; set => codigo = value; }
        public string Nombre{ get => nombre; set => nombre = value; }
        public string Autor{ get => autor; set => autor = value; }
        public bool Estado { get => estado; set => estado = value; }

        public void Prestar()
        {
            if (!Estado)
            {
                Estado  = true;
                Console.WriteLine($"El videojuego {Nombre} ha sido prestado.");
            }
            else
            {
                Console.WriteLine($"El videojuego {Nombre} ya está prestado.");
            }
        }

        public void Entregar()
        {
            if (Estado)
            {
                Estado = false;
                Console.WriteLine($"El videojuego {Nombre} ha sido devuelto.");
            }
            else
            {
                Console.WriteLine($"El videojuego {Nombre} no está prestado.");
            }
        }

        public override string ToString()
        {
            string estado = Estado ? "Prestado" : "Disponible";
            return $"Código: {Codigo}, Nombre: {Nombre}, Autor: {Autor}, Estado: {estado}";
        }
    }
}
