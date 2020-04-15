using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDocentes
{
    class Libro
    {
        public String Titulo { get; set; }
        public String Autor { get; set; }

        public override string ToString()
        {
            return "Titulo:"+Titulo+" Autor:"+Autor;
        }
    }
}
