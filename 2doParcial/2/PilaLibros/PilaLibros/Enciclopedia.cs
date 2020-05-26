using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaLibros
{
    class Enciclopedia : Libro
    {
        string nombre;
        string editorial, tema;

        public Enciclopedia(string nombre, string editorial, string tema)
        {
            this.nombre = nombre;
            this.editorial = editorial;
            this.tema = tema;
        }

        public string mostrar()
        {
            return "Enciclopedia: " + nombre + " Editorial:" + editorial + " tema:" + tema;
                
        }

        public override string ToString()
        {
            return mostrar();
        }
    }
}
