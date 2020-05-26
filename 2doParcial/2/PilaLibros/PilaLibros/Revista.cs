using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaLibros
{
    class Revista : Libro
    {
        string titulo;
        int nropaginas;

        public Revista(string titulo, int nropaginas)
        {
            this.titulo = titulo;
            this.nropaginas = nropaginas;
        }

        public string mostrar()
        {
            return "Revista: " + titulo + " nropagonas:" + nropaginas;

        }

        public override string ToString()
        {
            return mostrar();
        }
    }
}
