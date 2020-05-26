using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaLibros
{
    class Novela : Libro
    {
        string titulo,autor;
        Genero genero;

        public Novela(string titulo, string autor, Genero genero)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.genero = genero;
        }

        public string mostrar()
        {
            return "Novela: " + titulo+ " Autor:" + autor + " genero:" + genero;

        }

        public override string ToString()
        {
            return mostrar();
        }
    }
    public enum Genero { acción, romance, terror }
}
