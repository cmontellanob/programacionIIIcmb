using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico
{
    abstract class Mamifero
    {
        
        private string nombre;

        protected Mamifero(string nombre)
        {
            this.nombre = nombre;
        }
    }
    class Leon : Mamifero
    {
        protected Leon(string nombre) : base(nombre)
        {
        }
    }
}
