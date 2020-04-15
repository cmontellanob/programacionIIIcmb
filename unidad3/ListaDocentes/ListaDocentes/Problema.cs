using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDocentes
{
    class Problema
    {
        public String Titulo { get; set; }
        public String Descripcion { get; set; }
         public  override String ToString()
        {
            return Titulo + "   " + Descripcion;
        }
    }
}
